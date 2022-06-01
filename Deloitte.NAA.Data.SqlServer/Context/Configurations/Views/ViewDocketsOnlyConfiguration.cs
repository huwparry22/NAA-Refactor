using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewDocketsOnlyConfiguration : IEntityTypeConfiguration<ViewDocketsOnly>
    {
        public void Configure(EntityTypeBuilder<ViewDocketsOnly> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_DocketsOnly");

            builder.Property(e => e.ConsultationTypeId)
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.StateChange).HasColumnType("datetime");

            builder.Property(e => e.StateId).HasColumnName("StateID");
        }
    }
}
