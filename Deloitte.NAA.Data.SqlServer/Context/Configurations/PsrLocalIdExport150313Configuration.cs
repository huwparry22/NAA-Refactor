using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PsrLocalIdExport150313Configuration : IEntityTypeConfiguration<PsrLocalIdExport150313>
    {
        public void Configure(EntityTypeBuilder<PsrLocalIdExport150313> builder)
        {
            builder.HasNoKey();

            builder.ToTable("PSR_LocalID_Export_150313$");

            builder.Property(e => e.CountryOfIncorporation)
                .HasColumnName("Country of Incorporation")
                .HasMaxLength(255);

            builder.Property(e => e.EntityDuns)
                .HasColumnName("Entity DUNS")
                .HasMaxLength(255);

            builder.Property(e => e.EntityName)
                .HasColumnName("Entity Name")
                .HasMaxLength(255);

            builder.Property(e => e.LocalId)
                .HasColumnName("Local ID")
                .HasMaxLength(255);
        }
    }
}
