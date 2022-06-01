using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicConfigDataConfiguration : IEntityTypeConfiguration<FicConfigData>
    {
        public void Configure(EntityTypeBuilder<FicConfigData> builder)
        {
            builder.HasKey(e => new { e.FicconfigId, e.FicconfigDataId });

            builder.ToTable("FICConfigData");

            builder.Property(e => e.FicconfigId).HasColumnName("FICConfigID");

            builder.Property(e => e.FicconfigDataId).HasColumnName("FICConfigDataID");

            builder.Property(e => e.SequenceId).HasColumnName("SequenceID");
        }
    }
}
