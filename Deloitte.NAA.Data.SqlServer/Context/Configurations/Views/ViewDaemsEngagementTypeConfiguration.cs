using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewDaemsEngagementTypeConfiguration : IEntityTypeConfiguration<ViewDaemsEngagementType>
    {
        public void Configure(EntityTypeBuilder<ViewDaemsEngagementType> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_DAEMSEngagementType");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(39)
                .IsUnicode(false);

            builder.Property(e => e.EngagementTypeId).HasColumnName("EngagementTypeID");
        }
    }
}
