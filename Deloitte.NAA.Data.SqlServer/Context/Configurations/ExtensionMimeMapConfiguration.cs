using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ExtensionMimeMapConfiguration : IEntityTypeConfiguration<ExtensionMimeMap>
    {
        public void Configure(EntityTypeBuilder<ExtensionMimeMap> builder)
        {
            //builder.HasIndex(e => e.Extension)
            //        .HasName("IX_ExtensionMimeMap")
            //        .IsUnique();

            builder.Property(e => e.ExtensionMimeMapId).HasColumnName("ExtensionMimeMapID");

            builder.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

            builder.Property(e => e.Extension)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.MimeType)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
