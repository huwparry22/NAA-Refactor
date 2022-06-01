using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewFileStatusTextConfiguration : IEntityTypeConfiguration<ViewFileStatusText>
    {
        public void Configure(EntityTypeBuilder<ViewFileStatusText> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_FileStatusText");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false);

            builder.Property(e => e.TypeOfConsultationId).HasColumnName("TypeOfConsultationID");
        }
    }
}
