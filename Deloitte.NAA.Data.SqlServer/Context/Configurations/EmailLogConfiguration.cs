using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EmailLogConfiguration : IEntityTypeConfiguration<EmailLog>
    {
        public void Configure(EntityTypeBuilder<EmailLog> builder)
        {
            builder.HasIndex(e => e.EmailRecipientId);

            builder.Property(e => e.EmailLogId).HasColumnName("EmailLogID");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.EmailRecipientId).HasColumnName("EmailRecipientID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.EmailRecipient)
                .WithMany(p => p.EmailLog)
                .HasForeignKey(d => d.EmailRecipientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailLog_EmailRecipient");
        }
    }
}
