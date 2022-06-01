using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class SatelliteFirmConfiguration : IEntityTypeConfiguration<SatelliteFirm>
    {
        public void Configure(EntityTypeBuilder<SatelliteFirm> builder)
        {
            builder.Property(e => e.SatelliteFirmId).HasColumnName("SatelliteFirmID");

            builder.Property(e => e.Adcode)
                .IsRequired()
                .HasColumnName("ADCode")
                .HasMaxLength(2)
                .IsFixedLength();

            builder.Property(e => e.FirmCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength();

            builder.Property(e => e.LocationName)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(d => d.FirmCodeNavigation)
                .WithMany(p => p.SatelliteFirm)
                .HasPrincipalKey(p => p.FirmCode)
                .HasForeignKey(d => d.FirmCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SatelliteFirm_MemberFirm");
        }
    }
}
