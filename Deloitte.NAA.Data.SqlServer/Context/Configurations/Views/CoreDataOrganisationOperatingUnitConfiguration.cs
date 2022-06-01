using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class CoreDataOrganisationOperatingUnitConfiguration : IEntityTypeConfiguration<CoreDataOrganisationOperatingUnit>
    {
        public void Configure(EntityTypeBuilder<CoreDataOrganisationOperatingUnit> builder)
        {
            builder.HasNoKey();

            builder.ToView("CoreData_OrganisationOperatingUnit");

            builder.Property(e => e.LegalCompanyId)
                .IsRequired()
                .HasColumnName("LegalCompanyID")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.LegalCompanyText).HasMaxLength(50);

            builder.Property(e => e.OperatingUnitText)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.ServiceLineId).HasColumnName("ServiceLineID");

            builder.Property(e => e.ServiceLineText)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.SubServiceLineId).HasColumnName("SubServiceLineID");

            builder.Property(e => e.SubServiceLineText)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
