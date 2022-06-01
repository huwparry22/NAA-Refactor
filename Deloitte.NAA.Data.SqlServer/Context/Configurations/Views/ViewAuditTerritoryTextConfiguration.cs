using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewAuditTerritoryTextConfiguration : IEntityTypeConfiguration<ViewAuditTerritoryText>
    {
        public void Configure(EntityTypeBuilder<ViewAuditTerritoryText> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_AuditTerritoryText");

            builder.Property(e => e.AuditTerritoryId).HasColumnName("AuditTerritoryID");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false);
        }
    }
}
