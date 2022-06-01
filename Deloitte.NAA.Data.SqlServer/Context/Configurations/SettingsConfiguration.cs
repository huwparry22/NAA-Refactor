using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class SettingsConfiguration : IEntityTypeConfiguration<Settings>
    {
        public void Configure(EntityTypeBuilder<Settings> builder)
        {
            builder.Property(e => e.SettingsId).HasColumnName("SettingsID");

            builder.Property(e => e.Key)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Value).IsUnicode(false);
        }
    }
}
