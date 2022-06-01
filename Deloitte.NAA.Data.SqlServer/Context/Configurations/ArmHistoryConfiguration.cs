using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ArmHistoryConfiguration : IEntityTypeConfiguration<ArmHistory>
    {
        public void Configure(EntityTypeBuilder<ArmHistory> builder)
        {
            builder.ToTable("ARMHistory");

            builder.Property(e => e.ArmhistoryId).HasColumnName("ARMHistoryID");

            builder.Property(e => e.ArmentityId)
                .IsRequired()
                .HasColumnName("ARMEntityID")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ArmhistoryRowVersion)
                .IsRequired()
                .HasColumnName("ARMHistoryRowVersion")
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.DateImportedFromArm)
                .HasColumnName("DateImportedFromARM")
                .HasColumnType("datetime");

            builder.Property(e => e.EntityName)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");
        }
    }
}
