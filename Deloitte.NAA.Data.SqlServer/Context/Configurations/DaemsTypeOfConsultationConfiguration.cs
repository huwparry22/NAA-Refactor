using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DaemsTypeOfConsultationConfiguration : IEntityTypeConfiguration<DaemsTypeOfConsultation>
    {
        public void Configure(EntityTypeBuilder<DaemsTypeOfConsultation> builder)
        {
            builder.ToTable("DAEMSTypeOfConsultation");

            builder.Property(e => e.DaemstypeOfConsultationId).HasColumnName("DAEMSTypeOfConsultationID");

            builder.Property(e => e.EmailId)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.TypeOfConsultation)
                .IsRequired()
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.UpdatedOn).HasColumnType("datetime");
        }
    }
}
