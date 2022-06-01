using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewSystemRoleConfiguration : IEntityTypeConfiguration<ViewSystemRole>
    {
        public void Configure(EntityTypeBuilder<ViewSystemRole> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_SystemRole");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");
        }
    }
}
