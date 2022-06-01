using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ConsultationDocumentConfiguration : IEntityTypeConfiguration<ConsultationDocument>
    {
        public void Configure(EntityTypeBuilder<ConsultationDocument> builder)
        {
            builder.Property(e => e.ConsultationDocumentId).HasColumnName("ConsultationDocumentID");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.DocumentId)
                .IsRequired()
                .HasColumnName("DocumentID")
                .HasMaxLength(50);

            builder.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
