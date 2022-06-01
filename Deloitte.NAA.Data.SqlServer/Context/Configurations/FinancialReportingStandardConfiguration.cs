using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FinancialReportingStandardConfiguration : IEntityTypeConfiguration<FinancialReportingStandard>
    {
        public void Configure(EntityTypeBuilder<FinancialReportingStandard> builder)
        {
            builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
        }
    }
}
