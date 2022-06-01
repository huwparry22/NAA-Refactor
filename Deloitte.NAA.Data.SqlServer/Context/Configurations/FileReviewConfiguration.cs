using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FileReviewConfiguration : IEntityTypeConfiguration<FileReview>
    {
        public void Configure(EntityTypeBuilder<FileReview> builder)
        {
            builder.HasKey(e => e.ReviewBaseId)
                    .HasName("PK_Indent");

            builder.Property(e => e.ReviewBaseId)
                .HasColumnName("ReviewBaseID")
                .ValueGeneratedNever();

            builder.Property(e => e.ContactName)
                .HasMaxLength(75)
                .IsUnicode(false);

            builder.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FileReviewRowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.NotRequiredReason)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.HasOne(d => d.ReviewBase)
                .WithOne(p => p.FileReview)
                .HasForeignKey<FileReview>(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indent_ReviewBase1");
        }
    }
}
