using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ConsultationReviewPointConfiguration : IEntityTypeConfiguration<ConsultationReviewPoint>
    {
        public void Configure(EntityTypeBuilder<ConsultationReviewPoint> builder)
        {
            builder.Property(e => e.ConsultationReviewPointId).HasColumnName("ConsultationReviewPointID");

            builder.Property(e => e.Comments).HasColumnType("text");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UpdatedOn).HasColumnType("datetime");

            builder.HasOne(d => d.UpdatedByNavigation)
                .WithMany(p => p.ConsultationReviewPoint)
                .HasForeignKey(d => d.UpdatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsultationReviewPoint_User");
        }
    }
}
