using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewStatePreviewConfiguration : IEntityTypeConfiguration<ViewStatePreview>
    {
        public void Configure(EntityTypeBuilder<ViewStatePreview> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_StatePreview");

            builder.Property(e => e.FolderId).HasColumnName("FolderID");

            builder.Property(e => e.RoleId).HasColumnName("RoleID");

            builder.Property(e => e.StateId).HasColumnName("StateID");
        }
    }
}
