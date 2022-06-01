using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewConsultationTypeMatchConfiguration : IEntityTypeConfiguration<ViewConsultationTypeMatch>
    {
        public void Configure(EntityTypeBuilder<ViewConsultationTypeMatch> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ConsultationTypeMatch");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.Head)
                .HasMaxLength(14)
                .IsUnicode(false);

            builder.Property(e => e.Text)
                .HasMaxLength(8)
                .IsUnicode(false);
        }
    }
}
