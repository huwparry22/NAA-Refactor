using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FinancialReportingStandardMemberFirmConfiguration : IEntityTypeConfiguration<FinancialReportingStandardMemberFirm>
    {
        public void Configure(EntityTypeBuilder<FinancialReportingStandardMemberFirm> builder)
        {
            builder.HasOne(d => d.MemberFirm)
                    .WithMany(p => p.FinancialReportingStandardMemberFirm)
                    .HasForeignKey(d => d.MemberFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FinancialReportingStandardMemberFirm_MemberFirm");
        }
    }
}
