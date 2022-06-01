using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CemoApplicableMemberFirmsConfiguration : IEntityTypeConfiguration<CemoApplicableMemberFirms>
    {
        public void Configure(EntityTypeBuilder<CemoApplicableMemberFirms> builder)
        {
            builder.ToTable("CEMOApplicableMemberFirms");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.CemorequestReasonId).HasColumnName("CEMORequestReasonID");

            builder.HasOne(d => d.CemorequestReason)
                .WithMany(p => p.CemoapplicableMemberFirms)
                .HasForeignKey(d => d.CemorequestReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CEMOApplicableMemberFirms_CEMOApplicableMemberFirms");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.CemoapplicableMemberFirms)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CEMOApplicableMemberFirms_MemberFirm");
        }
    }
}
