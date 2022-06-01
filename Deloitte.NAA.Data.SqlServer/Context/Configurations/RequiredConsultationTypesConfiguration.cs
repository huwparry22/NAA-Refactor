using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class RequiredConsultationTypesConfiguration : IEntityTypeConfiguration<RequiredConsultationTypes>
    {
        public void Configure(EntityTypeBuilder<RequiredConsultationTypes> builder)
        {
            builder.ToTable("RequiredConsultationTypess");

            builder.HasKey(e => e.RequiredConsultationTypeId)
                .HasName("PK_RequiredConsultationType");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
