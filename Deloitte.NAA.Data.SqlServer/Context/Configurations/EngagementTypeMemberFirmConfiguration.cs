using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EngagementTypeMemberFirmConfiguration : IEntityTypeConfiguration<EngagementTypeMemberFirm>
    {
        public void Configure(EntityTypeBuilder<EngagementTypeMemberFirm> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.HasOne(d => d.EngagementType)
                .WithMany(p => p.EngagementTypeMemberFirm)
                .HasForeignKey(d => d.EngagementTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EngagementTypeMemberFirmEngagementType");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.EngagementTypeMemberFirm)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EngagementTypeMemberFirm_MemberFirm");
        }
    }
}
