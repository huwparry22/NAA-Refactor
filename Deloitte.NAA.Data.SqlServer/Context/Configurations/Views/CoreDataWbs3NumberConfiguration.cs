using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class CoreDataWbs3NumberConfiguration : IEntityTypeConfiguration<CoreDataWbs3Number>
    {
        public void Configure(EntityTypeBuilder<CoreDataWbs3Number> builder)
        {
            builder.HasNoKey();

            builder.ToView("CoreData_WBS3Number");

            builder.Property(e => e.Wbs3number)
                .IsRequired()
                .HasColumnName("WBS3Number")
                .HasMaxLength(24)
                .IsUnicode(false);
        }
    }
}
