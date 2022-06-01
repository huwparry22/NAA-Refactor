using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewPreviewFolderConfiguration : IEntityTypeConfiguration<ViewPreviewFolder>
    {
        public void Configure(EntityTypeBuilder<ViewPreviewFolder> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_PreviewFolder");

            builder.Property(e => e.FolderId).HasColumnName("FolderID");
        }
    }
}
