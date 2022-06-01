using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class RelProfStandardsMemberFirmConfiguration : IEntityTypeConfiguration<RelProfStandardsMemberFirm>
    {
        public void Configure(EntityTypeBuilder<RelProfStandardsMemberFirm> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.RelProfStandardsMemberFirm)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelProfStandardsMemberFirm_MemberFirm");

            builder.HasOne(d => d.RelProfStandards)
                .WithMany(p => p.RelProfStandardsMemberFirm)
                .HasForeignKey(d => d.RelProfStandardsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelProfStandardsMemberFirmRelProfStandards");
        }
    }
}
