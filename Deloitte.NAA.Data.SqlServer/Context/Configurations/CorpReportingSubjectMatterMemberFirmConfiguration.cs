using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CorpReportingSubjectMatterMemberFirmConfiguration : IEntityTypeConfiguration<CorpReportingSubjectMatterMemberFirm>
    {
        public void Configure(EntityTypeBuilder<CorpReportingSubjectMatterMemberFirm> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.CorpReportingSubjectMatterMemberFirm)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorpReportingSubjectMatterMemberFirm_MemberFirm");
        }
    }
}
