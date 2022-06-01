using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationOtherIssueConfiguration : IEntityTypeConfiguration<FicConsultationOtherIssue>
    {
        public void Configure(EntityTypeBuilder<FicConsultationOtherIssue> builder)
        {
            builder.ToTable("FICConsultationOtherIssue");

            builder.Property(e => e.FicconsultationOtherIssueId).HasColumnName("FICConsultationOtherIssueID");

            builder.Property(e => e.Csa).HasColumnName("CSA");

            builder.Property(e => e.EmbeddedIdentifiedList).HasMaxLength(2000);

            builder.Property(e => e.EmbeddedProcedures).HasMaxLength(2000);

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.OtherFi)
                .HasColumnName("OtherFI")
                .HasMaxLength(2000);

            builder.Property(e => e.OtherRiskList).HasMaxLength(2000);

            builder.Property(e => e.Vaccalculated).HasColumnName("VACCalculated");

            builder.Property(e => e.VaccalculatedList)
                .HasColumnName("VACCalculatedList")
                .HasMaxLength(2000);

            builder.Property(e => e.Vacimpact)
                .HasColumnName("VACImpact")
                .HasMaxLength(2000);

            builder.Property(e => e.Vacprocedures)
                .HasColumnName("VACProcedures")
                .HasMaxLength(2000);

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationOtherIssue)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationOtherIssue_FICConsultation");
        }
    }
}
