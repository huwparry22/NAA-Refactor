using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PriviledgeConfiguration : IEntityTypeConfiguration<Priviledge>
    {
        public void Configure(EntityTypeBuilder<Priviledge> builder)
        {
            builder.Property(e => e.PriviledgeId).HasColumnName("PriviledgeID");

            builder.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
