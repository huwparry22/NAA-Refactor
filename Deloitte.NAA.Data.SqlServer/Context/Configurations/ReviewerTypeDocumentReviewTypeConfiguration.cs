using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewerTypeDocumentReviewTypeConfiguration : IEntityTypeConfiguration<ReviewerTypeDocumentReviewType>
    {
        public void Configure(EntityTypeBuilder<ReviewerTypeDocumentReviewType> builder)
        {
            builder.HasIndex(e => e.DocumentReviewTypeId);

            builder.HasIndex(e => e.ReviewerTypeId);

            builder.Property(e => e.ReviewerTypeDocumentReviewTypeId).HasColumnName("ReviewerTypeDocumentReviewTypeID");

            builder.Property(e => e.DocumentReviewTypeId).HasColumnName("DocumentReviewTypeID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.HasOne(d => d.DocumentReviewType)
                .WithMany(p => p.ReviewerTypeDocumentReviewType)
                .HasForeignKey(d => d.DocumentReviewTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewerTypeDocketType_DocketType");

            builder.HasOne(d => d.ReviewerType)
                .WithMany(p => p.ReviewerTypeDocumentReviewType)
                .HasForeignKey(d => d.ReviewerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewerTypeDocketType_ReviewerType");
        }
    }
}
