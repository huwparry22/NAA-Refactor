using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewPreviewFolderEntriesConfiguration : IEntityTypeConfiguration<ViewPreviewFolderEntries>
    {
        public void Configure(EntityTypeBuilder<ViewPreviewFolderEntries> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_PreviewFolderEntries");

            builder.Property(e => e.FolderId).HasColumnName("FolderID");
        }
    }
}
