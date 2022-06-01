using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationFinalConfiguration : IEntityTypeConfiguration<FicConsultationFinal>
    {
        public void Configure(EntityTypeBuilder<FicConsultationFinal> builder)
        {
            builder.ToTable("FICConsultationFinal");

            builder.Property(e => e.FicconsultationFinalId).HasColumnName("FICConsultationFinalID");

            builder.Property(e => e.ConfirmIhaveReviewed).HasColumnName("ConfirmIHaveReviewed");

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.HedgeAccountingId).HasColumnName("HedgeAccountingID");

            builder.Property(e => e.MemoReference).HasMaxLength(200);

            builder.Property(e => e.OtherFinalSignOffComments).HasMaxLength(2000);

            builder.Property(e => e.OtherSpecialistInvolved).HasMaxLength(200);

            builder.Property(e => e.RequestDate).HasColumnType("datetime");

            builder.Property(e => e.ValuationId).HasColumnName("ValuationID");

            builder.Property(e => e.ValuationIssuesIdentified)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationFinal)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationFinal_FICConsultation");
        }
    }
}
