using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicGridSummaryConfiguration : IEntityTypeConfiguration<FicGridSummary>
    {
        public void Configure(EntityTypeBuilder<FicGridSummary> builder)
        {
            builder.ToTable("FICGridSummary");

            builder.Property(e => e.FicgridSummaryId).HasColumnName("FICGridSummaryID");

            builder.Property(e => e.AccountingTreatment).HasMaxLength(500);

            builder.Property(e => e.FicgridId).HasColumnName("FICGridID");

            builder.Property(e => e.Purpose).HasMaxLength(500);

            builder.Property(e => e.ValuationTool).HasMaxLength(500);

            builder.HasOne(d => d.Ficgrid)
                .WithMany(p => p.FicgridSummary)
                .HasForeignKey(d => d.FicgridId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICGridSummary_FICGrid");
        }
    }
}
