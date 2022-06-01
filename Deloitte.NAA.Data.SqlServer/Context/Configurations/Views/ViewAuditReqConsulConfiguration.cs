using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewAuditReqConsulConfiguration : IEntityTypeConfiguration<ViewAuditReqConsul>
    {
        public void Configure(EntityTypeBuilder<ViewAuditReqConsul> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_AuditReqConsul");

            builder.Property(e => e.AuditConsultationId)
                .IsRequired()
                .HasColumnName("AuditConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Description).HasMaxLength(2000);
        }
    }
}
