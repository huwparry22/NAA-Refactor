using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class NaaConsultationConfiguration : IEntityTypeConfiguration<NaaConsultation>
    {
        public void Configure(EntityTypeBuilder<NaaConsultation> builder)
        {
            builder.ToTable("NAAConsultation");

            builder.Property(e => e.NaaconsultationId).HasColumnName("NAAConsultationID");

            builder.Property(e => e.Abbreviated).HasMaxLength(50);

            builder.Property(e => e.Email).HasMaxLength(250);

            builder.Property(e => e.HelpText).HasMaxLength(2000);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
