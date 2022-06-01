using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ArchivedHistoryConfiguration : IEntityTypeConfiguration<ArchivedHistory>
    {
        public void Configure(EntityTypeBuilder<ArchivedHistory> builder)
        {
            builder.Property(e => e.ActionDate).HasColumnType("datetime");

            builder.Property(e => e.ArchivedHistoryRowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.DateAmended).HasColumnType("datetime");

            builder.Property(e => e.Operation).HasMaxLength(50);

            builder.Property(e => e.Reference).HasMaxLength(2000);

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.ArchivedHistory)
                .HasForeignKey(d => d.ReviewBaseId)
                .HasConstraintName("FK_ArchivedHistory_ReviewBase1");
        }
    }
}
