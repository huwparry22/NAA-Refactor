using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class SubjectMatterMemberFirmConfiguration : IEntityTypeConfiguration<SubjectMatterMemberFirm>
    {
        public void Configure(EntityTypeBuilder<SubjectMatterMemberFirm> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.SubjectMatterMemberFirm)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubjectMatterMemberFirm_MemberFirm");
        }
    }
}
