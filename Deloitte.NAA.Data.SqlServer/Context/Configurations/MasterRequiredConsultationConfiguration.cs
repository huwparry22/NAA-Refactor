using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class MasterRequiredConsultationConfiguration : IEntityTypeConfiguration<MasterRequiredConsultation>
    {
        public void Configure(EntityTypeBuilder<MasterRequiredConsultation> builder)
        {
            builder.HasKey(e => e.ConsultationTypeId)
                    .HasName("PK_ConsultationType");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.BasisofDiscussion).HasMaxLength(2000);

            builder.Property(e => e.Code).HasMaxLength(20);

            builder.Property(e => e.Condition).HasMaxLength(2000);

            builder.Property(e => e.NaaconsultationId).HasColumnName("NAAConsultationID");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(e => e.OtherRemark).HasMaxLength(2000);

            builder.Property(e => e.Reference).HasMaxLength(2000);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.SummaryofDiscussion).HasMaxLength(2000);

            builder.HasOne(d => d.Naaconsultation)
                .WithMany(p => p.MasterRequiredConsultation)
                .HasForeignKey(d => d.NaaconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsultationType_NAAConsultation");
        }
    }
}
