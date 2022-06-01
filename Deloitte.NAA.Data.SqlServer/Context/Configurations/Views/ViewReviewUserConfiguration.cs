using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewReviewUserConfiguration : IEntityTypeConfiguration<ViewReviewUser>
    {
        public void Configure(EntityTypeBuilder<ViewReviewUser> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ReviewUser");

            builder.Property(e => e.ChangeDate).HasColumnType("datetime");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.StateId).HasColumnName("StateID");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
