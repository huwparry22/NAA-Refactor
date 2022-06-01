using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CodeColumnConstraintConfiguration : IEntityTypeConfiguration<CodeColumnConstraint>
    {
        public void Configure(EntityTypeBuilder<CodeColumnConstraint> builder)
        {
            builder.HasKey(e => new { e.TableSchema, e.TableName, e.ColumnName });

            builder.Property(e => e.TableSchema)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TableName)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.ColumnName)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.CodeId).HasColumnName("CodeID");

            builder.HasOne(d => d.Code)
                .WithMany(p => p.CodeColumnConstraint)
                .HasForeignKey(d => d.CodeId)
                .HasConstraintName("FK_CodeColumnConstraint_Code");
        }
    }
}
