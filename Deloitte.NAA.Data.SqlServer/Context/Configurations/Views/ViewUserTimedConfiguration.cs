using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewUserTimedConfiguration : IEntityTypeConfiguration<ViewUserTimed>
    {
        public void Configure(EntityTypeBuilder<ViewUserTimed> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_UserTimed");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.TimeSpent).HasColumnType("decimal(38, 2)");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
