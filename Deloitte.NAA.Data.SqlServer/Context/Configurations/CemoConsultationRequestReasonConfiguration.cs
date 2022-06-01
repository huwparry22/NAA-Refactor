using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CemoConsultationRequestReasonConfiguration : IEntityTypeConfiguration<CemoConsultationRequestReason>
    {
        public void Configure(EntityTypeBuilder<CemoConsultationRequestReason> builder)
        {
            builder.ToTable("CEMOConsultationRequestReason");

            //builder.HasIndex(e => e.CemoconsultationId)
            //    .HasName("CEMOConsultationID");

            builder.Property(e => e.CemoconsultationRequestReasonId).HasColumnName("CEMOConsultationRequestReasonID");

            builder.Property(e => e.CemoconsultationId)
                .IsRequired()
                .HasColumnName("CEMOConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.CemorequestReasonId).HasColumnName("CEMORequestReasonID");

            builder.Property(e => e.Other)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.Cemoconsultation)
                .WithMany(p => p.CemoconsultationRequestReason)
                .HasForeignKey(d => d.CemoconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CEMOConsultationRequestReason_CEMOConsultation");

            builder.HasOne(d => d.CemorequestReason)
                .WithMany(p => p.CemoconsultationRequestReason)
                .HasForeignKey(d => d.CemorequestReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CEMOConsultationRequestReason_CEMORequestReason");
        }
    }
}
