using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewReviewerNameConfiguration : IEntityTypeConfiguration<ViewReviewerName>
    {
        public void Configure(EntityTypeBuilder<ViewReviewerName> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ReviewerName");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.FullName).HasMaxLength(153);

            builder.Property(e => e.Independence).HasColumnType("datetime");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
