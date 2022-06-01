using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DelinquentRecipientsConfiguration : IEntityTypeConfiguration<DelinquentRecipients>
    {
        public void Configure(EntityTypeBuilder<DelinquentRecipients> builder)
        {
            builder.HasKey(e => e.DelinquentRecipientId);

            builder.Property(e => e.DelinquentRecipientId).HasColumnName("DelinquentRecipientID");

            builder.Property(e => e.DelinquentConfigId).HasColumnName("DelinquentConfigID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.DelinquentConfig)
                .WithMany(p => p.DelinquentRecipients)
                .HasForeignKey(d => d.DelinquentConfigId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DelinquentRecipients_DelinquentConfigurations");

            builder.HasOne(d => d.ReviewerType)
                .WithMany(p => p.DelinquentRecipients)
                .HasForeignKey(d => d.ReviewerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DelinquentRecipients_ReviewerType");
        }
    }
}
