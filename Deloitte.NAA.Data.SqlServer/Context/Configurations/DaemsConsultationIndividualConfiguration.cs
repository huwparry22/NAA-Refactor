using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DaemsConsultationIndividualConfiguration : IEntityTypeConfiguration<DaemsConsultationIndividual>
    {
        public void Configure(EntityTypeBuilder<DaemsConsultationIndividual> builder)
        {
            builder.ToTable("DAEMSConsultationIndividual");

            builder.Property(e => e.DaemsconsultationIndividualId).HasColumnName("DAEMSConsultationIndividualID");

            builder.Property(e => e.DaemsconsultationId)
                .IsRequired()
                .HasColumnName("DAEMSConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Role)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.Daemsconsultation)
                .WithMany(p => p.DaemsconsultationIndividual)
                .HasForeignKey(d => d.DaemsconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAEMSConsultationIndividual_DAEMSConsultation");

            builder.HasOne(d => d.User)
                .WithMany(p => p.DaemsconsultationIndividual)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAEMSConsultationIndividual_User");
        }
    }
}
