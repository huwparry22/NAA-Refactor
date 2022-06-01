using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PsrArmUpdateWsJobProgressConfiguration : IEntityTypeConfiguration<PsrArmUpdateWsJobProgress>
    {
        public void Configure(EntityTypeBuilder<PsrArmUpdateWsJobProgress> builder)
        {
            builder.ToTable("PSRARMUpdateWSJobProgress");

            builder.Property(e => e.BatchGuid).HasColumnName("BatchGUID");

            builder.Property(e => e.BatchSuccessfullyProcessedOn).HasColumnType("datetime");

            builder.Property(e => e.BatchSuccessfullySentOn).HasColumnType("datetime");

            builder.Property(e => e.ProcessFailureAttemptCount).HasDefaultValueSql("((0))");

            builder.Property(e => e.ProcessLastFailureAttempt).HasColumnType("datetime");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.SentFailureAttemptCount).HasDefaultValueSql("((0))");

            builder.Property(e => e.SentLastFailureAttempt).HasColumnType("datetime");
        }
    }
}
