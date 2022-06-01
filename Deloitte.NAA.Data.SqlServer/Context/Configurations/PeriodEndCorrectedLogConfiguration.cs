using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PeriodEndCorrectedLogConfiguration : IEntityTypeConfiguration<PeriodEndCorrectedLog>
    {
        public void Configure(EntityTypeBuilder<PeriodEndCorrectedLog> builder)
        {
            builder.HasNoKey();

            builder.Property(e => e.CorrectedOn).HasColumnType("datetime");

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.NewPeriodEnd).HasColumnType("datetime");

            builder.Property(e => e.OldPeriodEnd).HasColumnType("datetime");

            builder.Property(e => e.PsrlogNo).HasColumnName("PSRLogNo");
        }
    }
}
