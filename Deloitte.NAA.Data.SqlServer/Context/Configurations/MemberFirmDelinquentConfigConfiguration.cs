using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class MemberFirmDelinquentConfigConfiguration : IEntityTypeConfiguration<MemberFirmDelinquentConfig>
    {
        public void Configure(EntityTypeBuilder<MemberFirmDelinquentConfig> builder)
        {
            builder.ToTable("MemberFirmDelinquentconfig");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.CentralMailboxEmailId)
                .IsRequired()
                .HasColumnName("CentralMailboxEmailID")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.MemberfirmId).HasColumnName("MemberfirmID");

            builder.HasOne(d => d.Memberfirm)
                .WithMany(p => p.MemberFirmDelinquentconfig)
                .HasForeignKey(d => d.MemberfirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberFirmDelinquentconfig_MemberFirm");
        }
    }
}
