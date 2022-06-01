using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class MenuSecurityConfiguration : IEntityTypeConfiguration<MenuSecurity>
    {
        public void Configure(EntityTypeBuilder<MenuSecurity> builder)
        {
            builder.Property(e => e.MenuSecurityId).HasColumnName("MenuSecurityID");

            builder.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

            builder.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");

            builder.HasOne(d => d.SystemRole)
                .WithMany(p => p.MenuSecurity)
                .HasForeignKey(d => d.SystemRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MenuSecurity_SystemRole");
        }
    }
}
