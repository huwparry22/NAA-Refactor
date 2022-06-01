using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewCceEngagementTypesConfiguration : IEntityTypeConfiguration<ViewCceEngagementTypes>
    {
        public void Configure(EntityTypeBuilder<ViewCceEngagementTypes> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_CCEEngagementTypes");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.EngagementTypeId).ValueGeneratedOnAdd();
        }
    }
}
