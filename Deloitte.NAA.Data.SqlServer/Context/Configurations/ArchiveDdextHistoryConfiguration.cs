using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ArchiveDdextHistoryConfiguration : IEntityTypeConfiguration<ArchiveDdextHistory>
    {
        public void Configure(EntityTypeBuilder<ArchiveDdextHistory> builder)
        {
            builder.ToTable("ArchiveDDExtHistory");

            builder.Property(e => e.ArchiveDdextHistoryId).HasColumnName("ArchiveDDExtHistoryID");

            builder.Property(e => e.ExtendOn).HasColumnType("datetime");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
