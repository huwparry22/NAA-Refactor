using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class SlowMovingRecipientsConfiguration : IEntityTypeConfiguration<SlowMovingRecipients>
    {
        public void Configure(EntityTypeBuilder<SlowMovingRecipients> builder)
        {
            builder.HasKey(e => e.SlowmovingRecipientId);

            builder.Property(e => e.SlowmovingRecipientId).HasColumnName("SlowmovingRecipientID");

            builder.Property(e => e.DelinquentConfigId).HasColumnName("DelinquentConfigID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.DelinquentConfig)
                .WithMany(p => p.SlowMovingRecipients)
                .HasForeignKey(d => d.DelinquentConfigId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SlowMovingRecipients_DelinquentConfigurations");
        }
    }
}
