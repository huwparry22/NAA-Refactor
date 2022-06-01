using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicGridHedgeConfiguration : IEntityTypeConfiguration<FicGridHedge>
    {
        public void Configure(EntityTypeBuilder<FicGridHedge> builder)
        {
            builder.ToTable("FICGridHedge");

            builder.Property(e => e.FicgridHedgeId).HasColumnName("FICGridHedgeID");

            builder.Property(e => e.FicgridId).HasColumnName("FICGridID");

            builder.Property(e => e.HedgeEffectivenessTool).HasMaxLength(500);

            builder.HasOne(d => d.Ficgrid)
                .WithMany(p => p.FicgridHedge)
                .HasForeignKey(d => d.FicgridId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICGridHedge_FICGrid");
        }
    }
}
