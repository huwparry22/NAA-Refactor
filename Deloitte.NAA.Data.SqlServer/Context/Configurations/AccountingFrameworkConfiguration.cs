using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class AccountingFrameworkConfiguration : IEntityTypeConfiguration<AccountingFramework>
    {
        public void Configure(EntityTypeBuilder<AccountingFramework> builder)
        {
            //builder.HasIndex(e => e.AccountingConsultationId)
            //        .HasName("IndexAccountingConsultationID");

            builder.Property(e => e.AccountingFrameworkId).HasColumnName("AccountingFrameworkID");

            builder.Property(e => e.AccountingConsultationId)
                .IsRequired()
                .HasColumnName("AccountingConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.FrameworkId).HasColumnName("FrameworkID");

            builder.Property(e => e.Other)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.AccountingConsultation)
                .WithMany(p => p.AccountingFramework)
                .HasForeignKey(d => d.AccountingConsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountingFramework_AccountingConsultation");
        }
    }
}
