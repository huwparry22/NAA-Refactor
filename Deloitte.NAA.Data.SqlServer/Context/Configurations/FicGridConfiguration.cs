using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FicGridConfiguration : IEntityTypeConfiguration<FicGrid>
    {
        public void Configure(EntityTypeBuilder<FicGrid> builder)
        {
            builder.ToTable("FICGrid");

            builder.Property(e => e.FicgridId).HasColumnName("FICGridID");

            builder.Property(e => e.FicconsultationId)
                .IsRequired()
                .HasColumnName("FICConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.Ficconsultation)
                .WithMany(p => p.Ficgrid)
                .HasForeignKey(d => d.FicconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FICGrid_FICConsultation");
        }
    }
}
