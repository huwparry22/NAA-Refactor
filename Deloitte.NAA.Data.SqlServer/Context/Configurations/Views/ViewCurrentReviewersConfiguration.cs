using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewCurrentReviewersConfiguration : IEntityTypeConfiguration<ViewCurrentReviewers>
    {
        public void Configure(EntityTypeBuilder<ViewCurrentReviewers> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_CurrentReviewers");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.StartTime).HasColumnType("datetime");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
