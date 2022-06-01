using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationReviewConfiguration : IEntityTypeConfiguration<FicConsultationReview>
    {
        public void Configure(EntityTypeBuilder<FicConsultationReview> builder)
        {
            builder.ToTable("FICConsultationReview");

            builder.Property(e => e.FicconsultationReviewId).HasColumnName("FICConsultationReviewID");

            builder.Property(e => e.AuditSignOff).HasColumnType("datetime");

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.MemoRequestedDate).HasColumnType("datetime");

            builder.Property(e => e.OtherReviewInformation)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.PreferredReviewerReason)
                .HasMaxLength(75)
                .IsUnicode(false);

            builder.Property(e => e.PreferredReviewerUserId).HasColumnName("PreferredReviewerUserID");

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationReview)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationReview_FICConsultation");
        }
    }
}
