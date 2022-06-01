using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class RelatedQueriesConfiguration : IEntityTypeConfiguration<RelatedQueries>
    {
        public void Configure(EntityTypeBuilder<RelatedQueries> builder)
        {
            builder.Property(e => e.RelatedQueriesId).HasColumnName("RelatedQueriesID");

            builder.Property(e => e.RelatedReviewBaseId).HasColumnName("RelatedReviewBaseID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UpdatedOn).HasColumnType("datetime");

            builder.HasOne(d => d.RelatedReviewBase)
                .WithMany(p => p.RelatedQueriesRelatedReviewBase)
                .HasForeignKey(d => d.RelatedReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelatedQueries_ReviewBase1");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.RelatedQueriesReviewBase)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelatedQueries_ReviewBase");

            builder.HasOne(d => d.UpdatedByNavigation)
                .WithMany(p => p.RelatedQueries)
                .HasForeignKey(d => d.UpdatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelatedQueries_User");
        }
    }
}
