using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewerTypeConfiguration : IEntityTypeConfiguration<ReviewerType>
    {
        public void Configure(EntityTypeBuilder<ReviewerType> builder)
        {
            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.Description).HasMaxLength(150);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
