using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class OfflineEmailConfiguration : IEntityTypeConfiguration<OfflineEmail>
    {
        public void Configure(EntityTypeBuilder<OfflineEmail> builder)
        {
            builder.Property(e => e.OfflineEmailId).HasColumnName("OfflineEmailID");

            builder.Property(e => e.Address).IsRequired();

            builder.Property(e => e.Body).IsRequired();

            builder.Property(e => e.Date).HasColumnType("datetime");

            builder.Property(e => e.DateReceived).HasColumnType("datetime");

            builder.Property(e => e.EntryId)
                .IsRequired()
                .HasColumnName("EntryID")
                .HasMaxLength(500);

            builder.Property(e => e.FromEmail)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.FromName)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.Guid).HasColumnName("GUID");

            builder.Property(e => e.HtmlBody).IsRequired();

            builder.Property(e => e.PsrcreatedDate)
                .HasColumnName("PSRCreatedDate")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Psrprocessed).HasColumnName("PSRProcessed");

            builder.Property(e => e.PsrprocessedDate)
                .HasColumnName("PSRProcessedDate")
                .HasColumnType("datetime");

            builder.Property(e => e.Received).IsRequired();

            builder.Property(e => e.ReturnPath)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.SenderEmail)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.SenderName)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.Subject).IsRequired();

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
