using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PsrArmUpdateProcessConfiguration : IEntityTypeConfiguration<PsrArmUpdateProcess>
    {
        public void Configure(EntityTypeBuilder<PsrArmUpdateProcess> builder)
        {
            builder.HasKey(e => e.BatchGuid)
                    .HasName("BatchGUID");

            builder.ToTable("PSRARMUpdateProcess");

            builder.Property(e => e.BatchGuid)
                .HasColumnName("BatchGUID")
                .ValueGeneratedNever();

            builder.Property(e => e.SsisjobLastRun)
                .HasColumnName("SSISJobLastRun")
                .HasColumnType("datetime");

            builder.Property(e => e.WindowServiceProcessedLastRun).HasColumnType("datetime");

            builder.Property(e => e.WindowServiceSentLastRun).HasColumnType("datetime");
        }
    }
}
