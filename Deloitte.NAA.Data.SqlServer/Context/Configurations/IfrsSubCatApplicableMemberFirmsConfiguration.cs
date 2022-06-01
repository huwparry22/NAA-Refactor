using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class IfrsSubCatApplicableMemberFirmsConfiguration : IEntityTypeConfiguration<IfrsSubCatApplicableMemberFirms>
    {
        public void Configure(EntityTypeBuilder<IfrsSubCatApplicableMemberFirms> builder)
        {
            builder.ToTable("IFRSSubCatApplicableMemberFirms");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.IfrssubCatId).HasColumnName("IFRSSubCatID");

            builder.HasOne(d => d.IfrssubCat)
                .WithMany(p => p.IfrssubCatApplicableMemberFirms)
                .HasForeignKey(d => d.IfrssubCatId)
                .HasConstraintName("FK_IFRSSubCatApplicableMemberFirms_IFRSSubCatApplicableMemberFirms");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.IfrssubCatApplicableMemberFirms)
                .HasForeignKey(d => d.MemberFirmId)
                .HasConstraintName("FK_IFRSSubCatApplicableMemberFirms_MemberFirm");
        }
    }
}
