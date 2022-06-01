using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewArmFieldConfiguration : IEntityTypeConfiguration<ReviewArmField>
    {
        public void Configure(EntityTypeBuilder<ReviewArmField> builder)
        {
            builder.ToTable("ReviewARMField");

            builder.HasIndex(e => e.ReviewBaseId);

            builder.Property(e => e.ReviewArmfieldId).HasColumnName("ReviewARMFieldID");

            builder.Property(e => e.ArmfieldId).HasColumnName("ARMFieldID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.HasOne(d => d.Armfield)
                .WithMany(p => p.ReviewArmfield)
                .HasForeignKey(d => d.ArmfieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewARMField_ARMField");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.ReviewArmfield)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewARMField_ReviewBase");
        }
    }
}
