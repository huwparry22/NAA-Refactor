using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ArmFieldConfiguration : IEntityTypeConfiguration<ArmField>
    {
        public void Configure(EntityTypeBuilder<ArmField> builder)
        {
            builder.ToTable("ARMField");

            builder.Property(e => e.ArmfieldId).HasColumnName("ARMFieldID");

            builder.Property(e => e.ArmfieldDescription)
                .IsRequired()
                .HasColumnName("ARMFieldDescription")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
