using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DocumentDataConfiguration : IEntityTypeConfiguration<DocumentData>
    {
        public void Configure(EntityTypeBuilder<DocumentData> builder)
        {
            //builder.HasIndex(e => e.DocumentId)
            //        .HasName("IX_DocumentData")
            //        .IsUnique();

            builder.Property(e => e.DocumentDataId).HasColumnName("DocumentDataID");

            builder.Property(e => e.DocumentId).HasColumnName("DocumentID");

            builder.HasOne(d => d.Document)
                .WithOne(p => p.DocumentData)
                .HasForeignKey<DocumentData>(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentData_Document");
        }
    }
}
