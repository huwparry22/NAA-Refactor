using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DocumentReviewConfiguration : IEntityTypeConfiguration<DocumentReview>
    {
        public void Configure(EntityTypeBuilder<DocumentReview> builder)
        {
            builder.HasKey(e => e.ReviewBaseId)
                    .HasName("PK_Docket");

            builder.HasIndex(e => e.AuditReportDate);

            builder.HasIndex(e => e.DocumentReviewTypeId);

            builder.HasIndex(e => e.FinalSignOffDate);

            builder.HasIndex(e => e.FinalSignOffDelegate);

            builder.HasIndex(e => e.FinalSignOffPartner);

            builder.Property(e => e.ReviewBaseId)
                .HasColumnName("ReviewBaseID")
                .ValueGeneratedNever();

            builder.Property(e => e.ArchiveActionedDate).HasColumnType("datetime");

            builder.Property(e => e.ArchiveReference).HasMaxLength(2000);

            builder.Property(e => e.AuditReportDate).HasColumnType("datetime");

            builder.Property(e => e.DeadlineDate).HasColumnType("datetime");

            builder.Property(e => e.DocumentReviewRowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.DocumentReviewTypeId).HasColumnName("DocumentReviewTypeID");

            builder.Property(e => e.FinalSignOffDate).HasColumnType("datetime");

            builder.Property(e => e.ProofReadBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ReviewPriorityReason)
                .HasMaxLength(75)
                .IsUnicode(false);

            builder.Property(e => e.WincheckGrade)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.WincheckName)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.DocumentReviewType)
                .WithMany(p => p.DocumentReview)
                .HasForeignKey(d => d.DocumentReviewTypeId)
                .HasConstraintName("FK_Docket_DocketType");

            builder.HasOne(d => d.FinalSignOffPartnerNavigation)
                .WithMany(p => p.DocumentReview)
                .HasForeignKey(d => d.FinalSignOffPartner)
                .HasConstraintName("FK_Docket_ReviewUser");

            builder.HasOne(d => d.ReviewBase)
                .WithOne(p => p.DocumentReview)
                .HasForeignKey<DocumentReview>(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Docket_ReviewBase1");
        }
    }
}
