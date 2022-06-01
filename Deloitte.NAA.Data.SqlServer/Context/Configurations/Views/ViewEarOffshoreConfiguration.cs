using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewEarOffshoreConfiguration : IEntityTypeConfiguration<ViewEarOffshore>
    {
        public void Configure(EntityTypeBuilder<ViewEarOffshore> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_EAROffshore");

            builder.Property(e => e.Description).HasMaxLength(250);

            builder.Property(e => e.EarconsultationId)
                .IsRequired()
                .HasColumnName("EARConsultationID")
                .HasMaxLength(50);
        }
    }
}
