using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DelinquentConfigurationsConfiguration : IEntityTypeConfiguration<DelinquentConfigurations>
    {
        public void Configure(EntityTypeBuilder<DelinquentConfigurations> builder)
        {
            builder.HasKey(e => e.DelinquentConfigId);

            builder.Property(e => e.DelinquentConfigId).HasColumnName("DelinquentConfigID");

            builder.Property(e => e.MemberfirmId)
                .HasColumnName("MemberfirmID")
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.NaaconsultationId).HasColumnName("NAAConsultationID");

            builder.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.StateId).HasColumnName("StateID");

            builder.HasOne(d => d.Memberfirm)
                .WithMany(p => p.DelinquentConfigurations)
                .HasForeignKey(d => d.MemberfirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DelinquentConfigurations_MemberFirm");

            builder.HasOne(d => d.State)
                .WithMany(p => p.DelinquentConfigurations)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DelinquentConfigurations_State");
        }
    }
}
