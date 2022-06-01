using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DaemsApplicableMemberFirmsConfiguration : IEntityTypeConfiguration<DaemsApplicableMemberFirms>
    {
        public void Configure(EntityTypeBuilder<DaemsApplicableMemberFirms> builder)
        {
            builder.ToTable("DAEMSApplicableMemberFirms");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.CrossBorderUrl)
                .HasColumnName("CrossBorderURL")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.MemberFirmId).HasColumnName("MemberFirmID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.DaemsapplicableMemberFirms)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAEMSApplicableMemberFirms_MemberFirm");
        }
    }
}
