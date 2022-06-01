using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DaemsVersionConfiguration : IEntityTypeConfiguration<DaemsVersion>
    {
        public void Configure(EntityTypeBuilder<DaemsVersion> builder)
        {
            builder.ToTable("DAEMSVersion");

            builder.Property(e => e.DaemsversionId).HasColumnName("DAEMSVersionID");

            builder.Property(e => e.Emsversion)
                .IsRequired()
                .HasColumnName("EMSVersion")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
