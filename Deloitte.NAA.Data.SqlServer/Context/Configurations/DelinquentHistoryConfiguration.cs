using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DelinquentHistoryConfiguration : IEntityTypeConfiguration<DelinquentHistory>
    {
        public void Configure(EntityTypeBuilder<DelinquentHistory> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.ConsultationId)
                .IsRequired()
                .HasColumnName("ConsultationID")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.EmailSentDateTime).HasColumnType("datetime");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.DelinquentHistory)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DelinquentHistory_ReviewBase");
        }
    }
}
