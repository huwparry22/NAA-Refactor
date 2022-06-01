using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DuplicateReviewsConfiguration : IEntityTypeConfiguration<DuplicateReviews>
    {
        public void Configure(EntityTypeBuilder<DuplicateReviews> builder)
        {
            builder.HasIndex(e => e.DuplicateId);

            builder.HasIndex(e => e.ReviewBaseId);

            builder.Property(e => e.DuplicateReviewsId).HasColumnName("DuplicateReviewsID");

            builder.Property(e => e.DuplicateId).HasColumnName("DuplicateID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.DuplicateReviews)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DuplicateReviews_ReviewBase");
        }
    }
}
