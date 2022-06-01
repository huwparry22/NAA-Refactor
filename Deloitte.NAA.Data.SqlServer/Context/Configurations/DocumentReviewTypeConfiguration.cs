using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DocumentReviewTypeConfiguration : IEntityTypeConfiguration<DocumentReviewType>
    {
        public void Configure(EntityTypeBuilder<DocumentReviewType> builder)
        {
            builder.HasIndex(e => e.DocumentReviewTypeCategoryId);

            builder.Property(e => e.DocumentReviewTypeId).HasColumnName("DocumentReviewTypeID");

            builder.Property(e => e.Active).HasDefaultValueSql("((1))");

            builder.Property(e => e.Armsearch).HasColumnName("ARMSearch");

            builder.Property(e => e.DocumentReviewTypeCategoryId).HasColumnName("DocumentReviewTypeCategoryID");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.Sec).HasColumnName("SEC");

            builder.HasOne(d => d.DocumentReviewTypeCategory)
                .WithMany(p => p.DocumentReviewType)
                .HasForeignKey(d => d.DocumentReviewTypeCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocketType_DocketTypeCategory");
        }
    }
}
