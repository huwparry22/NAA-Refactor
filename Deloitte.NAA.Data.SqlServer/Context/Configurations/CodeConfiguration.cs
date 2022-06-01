using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CodeConfiguration : IEntityTypeConfiguration<Code>
    {
        public void Configure(EntityTypeBuilder<Code> builder)
        {
            builder.Property(e => e.CodeId)
                    .HasColumnName("CodeID")
                    .ValueGeneratedNever();

            builder.Property(e => e.CodeDescription).HasMaxLength(250);

            builder.Property(e => e.CodeName).HasMaxLength(100);

            builder.Property(e => e.CodeStoredProcedure)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
