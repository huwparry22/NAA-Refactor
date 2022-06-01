using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class OfflineEmailFailureConfiguration : IEntityTypeConfiguration<OfflineEmailFailure>
    {
        public void Configure(EntityTypeBuilder<OfflineEmailFailure> builder)
        {
            builder.HasIndex(e => e.OfflineEmailId);

            builder.Property(e => e.OfflineEmailFailureId).HasColumnName("OfflineEmailFailureID");

            builder.Property(e => e.Message)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(e => e.OfflineEmailId).HasColumnName("OfflineEmailID");

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.OfflineEmail)
                .WithMany(p => p.OfflineEmailFailure)
                .HasForeignKey(d => d.OfflineEmailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OfflineEmailFailure_OfflineEmail");
        }
    }
}
