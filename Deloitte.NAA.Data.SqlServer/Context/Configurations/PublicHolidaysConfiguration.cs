using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PublicHolidaysConfiguration : IEntityTypeConfiguration<PublicHolidays>
    {
        public void Configure(EntityTypeBuilder<PublicHolidays> builder)
        {
            builder.HasKey(e => e.HolidayId)
                    .HasName("PK_PublicHoliday");

            builder.Property(e => e.HolidayId).HasColumnName("HolidayID");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.HolidayDate).HasColumnType("datetime");

            builder.Property(e => e.HolidayDescription)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
