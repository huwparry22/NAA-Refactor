using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewUserRoleConfiguration : IEntityTypeConfiguration<ViewUserRole>
    {
        public void Configure(EntityTypeBuilder<ViewUserRole> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_UserRole");

            builder.Property(e => e.MemberFirmId).HasColumnName("MemberFirmID");

            builder.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
        }
    }
}
