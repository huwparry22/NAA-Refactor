using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class HotlineClosureSettingConfiguration : IEntityTypeConfiguration<HotlineClosureSetting>
    {
        public void Configure(EntityTypeBuilder<HotlineClosureSetting> builder)
        {
            builder.Property(e => e.HotlineClosureSettingId).HasColumnName("HotlineClosureSettingID");

            builder.Property(e => e.EndDate).HasColumnType("datetime");

            builder.Property(e => e.MemberFirmId)
                .HasColumnName("MemberFirmID")
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.MessageText)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.HotlineClosureSetting)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HotlineClosureSetting_MemberFirm");
        }
    }
}
