using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DocumentReviewTypeCategoryConfiguration : IEntityTypeConfiguration<DocumentReviewTypeCategory>
    {
        public void Configure(EntityTypeBuilder<DocumentReviewTypeCategory> builder)
        {
            builder.Property(e => e.DocumentReviewTypeCategoryId).HasColumnName("DocumentReviewTypeCategoryID");

            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(700);
        }
    }
}
