using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewAuditStandardTextConfiguration : IEntityTypeConfiguration<ViewAuditStandardText>
    {
        public void Configure(EntityTypeBuilder<ViewAuditStandardText> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_AuditStandardText");

            builder.Property(e => e.AuditStandardId).HasColumnName("AuditStandardID");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(22)
                .IsUnicode(false);
        }
    }
}
