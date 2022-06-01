using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewPointConfiguration : IEntityTypeConfiguration<ReviewPoint>
    {
        public void Configure(EntityTypeBuilder<ReviewPoint> builder)
        {
            builder.HasIndex(e => e.CreatedByReviewUserId);

            builder.HasIndex(e => e.ReviewBaseId);

            builder.HasIndex(e => e.SupportingDocumentId);

            builder.Property(e => e.ReviewPointId).HasColumnName("ReviewPointID");

            builder.Property(e => e.ConsultationId)
                .IsRequired()
                .HasColumnName("ConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.CreatedByReviewUserId).HasColumnName("CreatedByReviewUserID");

            builder.Property(e => e.DateRaised).HasColumnType("datetime");

            builder.Property(e => e.Description).HasMaxLength(2048);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.SupportingDocumentId).HasColumnName("SupportingDocumentID");

            builder.HasOne(d => d.CreatedByReviewUser)
                .WithMany(p => p.ReviewPoint)
                .HasForeignKey(d => d.CreatedByReviewUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewPoint_CreatedByUser");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.ReviewPoint)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewPoint_ReviewBase");

            builder.HasOne(d => d.SupportingDocument)
                .WithMany(p => p.ReviewPoint)
                .HasForeignKey(d => d.SupportingDocumentId)
                .HasConstraintName("FK_ReviewPoint_SupportingDocument");
        }
    }
}
