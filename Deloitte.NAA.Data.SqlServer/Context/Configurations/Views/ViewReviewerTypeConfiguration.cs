using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewReviewerTypeConfiguration : IEntityTypeConfiguration<ViewReviewerType>
    {
        public void Configure(EntityTypeBuilder<ViewReviewerType> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ReviewerType");

            builder.Property(e => e.Description).HasMaxLength(150);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");
        }
    }
}
