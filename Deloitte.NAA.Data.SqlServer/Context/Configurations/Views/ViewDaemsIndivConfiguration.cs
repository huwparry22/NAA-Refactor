using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewDaemsIndivConfiguration : IEntityTypeConfiguration<ViewDaemsIndiv>
    {
        public void Configure(EntityTypeBuilder<ViewDaemsIndiv> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_DAEMSIndiv");

            builder.Property(e => e.DaemsconsultationId)
                .IsRequired()
                .HasColumnName("DAEMSConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.FullName).HasMaxLength(153);
        }
    }
}
