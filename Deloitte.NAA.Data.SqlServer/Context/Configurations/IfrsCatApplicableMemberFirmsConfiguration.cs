using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class IfrsCatApplicableMemberFirmsConfiguration : IEntityTypeConfiguration<IfrsCatApplicableMemberFirms>
    {
        public void Configure(EntityTypeBuilder<IfrsCatApplicableMemberFirms> builder)
        {
            builder.ToTable("IFRSCatApplicableMemberFirms");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Ifrsid).HasColumnName("IFRSID");

            builder.HasOne(d => d.Ifrs)
                .WithMany(p => p.IfrscatApplicableMemberFirms)
                .HasForeignKey(d => d.Ifrsid)
                .HasConstraintName("FK_IFRSCatApplicableMemberFirms_IFRSCatId");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.IfrscatApplicableMemberFirms)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IFRSCatApplicableMemberFirms_MemberFirm");
        }
    }
}
