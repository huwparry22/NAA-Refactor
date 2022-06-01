using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class AuditRequiredConsultationConfiguration : IEntityTypeConfiguration<AuditRequiredConsultation>
    {
        public void Configure(EntityTypeBuilder<AuditRequiredConsultation> builder)
        {
            builder.HasKey(e => e.ReviewConsultationTypeId)
                    .HasName("PK_ReviewConsultationType");

            //builder.HasIndex(e => e.NaaconsultationTypeId)
            //    .HasName("ConsultationTypeID");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.NaaconsultationTypeId)
                .IsRequired()
                .HasColumnName("NAAConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.Other).HasMaxLength(250);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
