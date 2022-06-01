using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewCemoReqReasonConfiguration : IEntityTypeConfiguration<ViewCemoReqReason>
    {
        public void Configure(EntityTypeBuilder<ViewCemoReqReason> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_CEMOReqReason");

            builder.Property(e => e.CemoconsultationId)
                .IsRequired()
                .HasColumnName("CEMOConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false);
        }
    }
}
