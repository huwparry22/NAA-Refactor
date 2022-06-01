using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasIndex(e => e.CreatedByUserId);

            builder.HasIndex(e => e.ModifiedByUserId);

            builder.HasIndex(e => e.OriginalDocumentId);

            builder.Property(e => e.DocumentId).HasColumnName("DocumentID");

            builder.Property(e => e.Charset)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(512);

            builder.Property(e => e.Encoding)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Extension)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

            builder.Property(e => e.ModifiedDate).HasColumnType("datetime");

            builder.Property(e => e.ModifiedFilename)
                .IsRequired()
                .HasMaxLength(512);

            builder.Property(e => e.OriginalDocumentId).HasColumnName("OriginalDocumentID");

            builder.Property(e => e.OriginalFilename)
                .IsRequired()
                .HasMaxLength(212);

            builder.HasOne(d => d.CreatedByUser)
                .WithMany(p => p.DocumentCreatedByUser)
                .HasForeignKey(d => d.CreatedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_CreatedByUser");

            builder.HasOne(d => d.ExtensionNavigation)
                .WithMany(p => p.Document)
                .HasPrincipalKey(p => p.Extension)
                .HasForeignKey(d => d.Extension)
                .HasConstraintName("FK_Document_ExtensionMimeMap");

            builder.HasOne(d => d.ModifiedByUser)
                .WithMany(p => p.DocumentModifiedByUser)
                .HasForeignKey(d => d.ModifiedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_ModifiedByUser");
        }
    }
}
