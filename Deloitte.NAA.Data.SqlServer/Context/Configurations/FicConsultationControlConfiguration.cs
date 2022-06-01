using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationControlConfiguration : IEntityTypeConfiguration<FicConsultationControl>
    {
        public void Configure(EntityTypeBuilder<FicConsultationControl> builder)
        {
            builder.ToTable("FICConsultationControl");

            builder.Property(e => e.FicconsultationControlId).HasColumnName("FICConsultationControlID");

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Process).HasMaxLength(2000);

            builder.Property(e => e.RiskReason).HasMaxLength(2000);

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationControl)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationControl_FICConsultation");
        }
    }
}
