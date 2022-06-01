using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class MemberFirmConsultationTypeConfiguration : IEntityTypeConfiguration<MemberFirmConsultationType>
    {
        public void Configure(EntityTypeBuilder<MemberFirmConsultationType> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.Email).HasMaxLength(100);

            builder.Property(e => e.HelpText).HasMaxLength(2000);

            builder.Property(e => e.MemberfirmId).HasColumnName("MemberfirmID");

            builder.Property(e => e.NaaconsultaionTypeId).HasColumnName("NAAConsultaionTypeId");

            builder.HasOne(d => d.Memberfirm)
                .WithMany(p => p.MemberFirmConsultationType)
                .HasForeignKey(d => d.MemberfirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberFirmConsultationType_MemberFirm");

            builder.HasOne(d => d.NaaconsultaionType)
                .WithMany(p => p.MemberFirmConsultationType)
                .HasForeignKey(d => d.NaaconsultaionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberFirmConsultationType_Naaconsultation");
        }
    }
}
