using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .ValueGeneratedNever();

            builder.Property(e => e.Text).HasMaxLength(50);
        }
    }
}
