using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConsultationRequiredDocumentConfiguration : IEntityTypeConfiguration<FicConsultationRequiredDocument>
    {
        public void Configure(EntityTypeBuilder<FicConsultationRequiredDocument> builder)
        {
            builder.ToTable("FICConsultationRequiredDocument");

            builder.Property(e => e.FicconsultationRequiredDocumentId).HasColumnName("FICConsultationRequiredDocumentID");

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.FicconsultationRequiredDocument)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICConsultationRequiredDocument_FICConsultation");
        }
    }
}
