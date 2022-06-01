using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EarConsultationOffshoreEntityConfiguration : IEntityTypeConfiguration<EarConsultationOffshoreEntity>
    {
        public void Configure(EntityTypeBuilder<EarConsultationOffshoreEntity> builder)
        {
            builder.ToTable("EARConsultationOffshoreEntity");

            builder.Property(e => e.EarconsultationOffshoreEntityId).HasColumnName("EARConsultationOffshoreEntityID");

            builder.Property(e => e.EarconsultationId)
                .IsRequired()
                .HasColumnName("EARConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.EaroffshoreEntityId).HasColumnName("EAROffshoreEntityID");

            builder.Property(e => e.Other)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.Earconsultation)
                .WithMany(p => p.EarconsultationOffshoreEntity)
                .HasForeignKey(d => d.EarconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EARConsultationOffshoreEntity_EARConsultation");
        }
    }
}
