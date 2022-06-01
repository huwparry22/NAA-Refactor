using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewBaseDocumentConfiguration : IEntityTypeConfiguration<ReviewBaseDocument>
    {
        public void Configure(EntityTypeBuilder<ReviewBaseDocument> builder)
        {
            builder.HasIndex(e => e.DocumentId);

            builder.HasIndex(e => e.ReviewBaseId);

            builder.Property(e => e.ReviewBaseDocumentId).HasColumnName("ReviewBaseDocumentID");

            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.ConsultationId)
                .IsRequired()
                .HasColumnName("ConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.DocumentId).HasColumnName("DocumentID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.SpfileUrl)
                .HasColumnName("SPFileURL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.UploadedToSharePoint).HasDefaultValueSql("((0))");

            builder.HasOne(d => d.Document)
                .WithMany(p => p.ReviewBaseDocument)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewBaseDocument_Document");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.ReviewBaseDocument)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewBaseDocument_ReviewBase");
        }
    }
}
