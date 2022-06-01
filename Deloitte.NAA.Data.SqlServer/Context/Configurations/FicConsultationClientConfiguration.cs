using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationClientConfiguration : IEntityTypeConfiguration<FicConsultationClient>
    {
        public void Configure(EntityTypeBuilder<FicConsultationClient> builder)
        {
            builder.ToTable("FICConsultationClient");

            builder.Property(e => e.FicconsultationClientId).HasColumnName("FICConsultationClientID");

            builder.Property(e => e.ClientFunctionalCurrencyOther).HasMaxLength(250);

            builder.Property(e => e.ClientReportingCurrencyOther).HasMaxLength(250);

            builder.Property(e => e.ClientsBusiness)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Gaapid).HasColumnName("GAAPID");

            builder.Property(e => e.UkCompaniesActReason).HasMaxLength(500);

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationClient)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationClient_FICConsultation");
        }
    }
}
