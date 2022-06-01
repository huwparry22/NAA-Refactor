using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EarApplicableMemberFirmsConfiguration : IEntityTypeConfiguration<EarApplicableMemberFirms>
    {
        public void Configure(EntityTypeBuilder<EarApplicableMemberFirms> builder)
        {
            builder.ToTable("EARApplicableMemberFirms");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.EarrequestReasonId).HasColumnName("EARRequestReasonID");

            builder.HasOne(d => d.EarrequestReason)
                .WithMany(p => p.EarapplicableMemberFirms)
                .HasForeignKey(d => d.EarrequestReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EARApplicableMemberFirms_EARResionID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.EarapplicableMemberFirms)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EARApplicableMemberFirms_MemberFirm");
        }
    }
}
