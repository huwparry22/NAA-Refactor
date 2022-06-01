using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationSummaryConfiguration : IEntityTypeConfiguration<FicConsultationSummary>
    {
        public void Configure(EntityTypeBuilder<FicConsultationSummary> builder)
        {
            builder.ToTable("FICConsultationSummary");

            builder.Property(e => e.FicconsultationSummaryId).HasColumnName("FICConsultationSummaryID");

            builder.Property(e => e.Details).HasMaxLength(2000);

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Objectives).HasMaxLength(2000);

            builder.Property(e => e.Procedures).HasMaxLength(2000);

            builder.Property(e => e.ValuationSource).HasMaxLength(2000);

            builder.Property(e => e.WhyIsSignificanceRisk).HasMaxLength(2000);

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationSummary)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationSummary_FICConsultation");
        }
    }
}
