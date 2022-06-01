using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UserDocumentTypeConfiguration : IEntityTypeConfiguration<UserDocumentType>
    {
        public void Configure(EntityTypeBuilder<UserDocumentType> builder)
        {
            builder.HasIndex(e => e.DocumentTypeId);

            builder.HasIndex(e => e.UserId);

            builder.Property(e => e.UserDocumentTypeId).HasColumnName("UserDocumentTypeID");

            builder.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.DocumentType)
                .WithMany(p => p.UserDocumentType)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserDocumentType_DocumentReviewType");

            builder.HasOne(d => d.User)
                .WithMany(p => p.UserDocumentType)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserDocumentType_User");
        }
    }
}
