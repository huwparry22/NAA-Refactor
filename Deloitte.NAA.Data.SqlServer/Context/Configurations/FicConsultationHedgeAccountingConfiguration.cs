using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationHedgeAccountingConfiguration : IEntityTypeConfiguration<FicConsultationHedgeAccounting>
    {
        public void Configure(EntityTypeBuilder<FicConsultationHedgeAccounting> builder)
        {
            builder.ToTable("FICConsultationHedgeAccounting");

            builder.Property(e => e.FicconsultationHedgeAccountingId).HasColumnName("FICConsultationHedgeAccountingID");

            builder.Property(e => e.Details).HasMaxLength(2000);

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Procedures).HasMaxLength(2000);

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationHedgeAccounting)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationHedgeAccounting_FICConsultation");
        }
    }
}
