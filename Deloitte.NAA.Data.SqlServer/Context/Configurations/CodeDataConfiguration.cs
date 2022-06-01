using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CodeDataConfiguration : IEntityTypeConfiguration<CodeData>
    {
        public void Configure(EntityTypeBuilder<CodeData> builder)
        {
            builder.HasKey(e => new { e.CodeId, e.CodeDataId });

            builder.Property(e => e.CodeId).HasColumnName("CodeID");

            builder.Property(e => e.CodeDataId).HasColumnName("CodeDataID");

            builder.Property(e => e.CodeData1)
                .HasColumnName("CodeData")
                .HasMaxLength(250);

            builder.Property(e => e.SequenceId).HasColumnName("SequenceID");

            builder.HasOne(d => d.Code)
                .WithMany(p => p.CodeData)
                .HasForeignKey(d => d.CodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodeData_Code");
        }
    }
}
