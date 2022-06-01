using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EmailAttachmentConfiguration : IEntityTypeConfiguration<EmailAttachment>
    {
        public void Configure(EntityTypeBuilder<EmailAttachment> builder)
        {
            builder.HasKey(e => e.AttachmentId);

            builder.HasIndex(e => e.EmailId);

            builder.HasIndex(e => e.ExtensionMimeMapId);

            builder.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

            builder.Property(e => e.Attachment).IsRequired();

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.EmailId).HasColumnName("EmailID");

            builder.Property(e => e.ExtensionMimeMapId).HasColumnName("ExtensionMimeMapID");

            builder.Property(e => e.Name).HasMaxLength(150);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.Email)
                .WithMany(p => p.EmailAttachment)
                .HasForeignKey(d => d.EmailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailAttachment_Email");

            builder.HasOne(d => d.ExtensionMimeMap)
                .WithMany(p => p.EmailAttachment)
                .HasForeignKey(d => d.ExtensionMimeMapId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailAttachment_ExtensionMimeMap");
        }
    }
}
