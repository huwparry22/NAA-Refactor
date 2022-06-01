using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class MasterConsultationMemberFirmsConfiguration : IEntityTypeConfiguration<MasterConsultationMemberFirms>
    {
        public void Configure(EntityTypeBuilder<MasterConsultationMemberFirms> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.HasOne(d => d.ConsultationType)
                .WithMany(p => p.MasterConsultationMemberFirms)
                .HasForeignKey(d => d.ConsultationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MasterConsultationMemberFirms_MasterConsultation");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.MasterConsultationMemberFirms)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MasterConsultationMemberFirms_MemberFirm");
        }
    }
}
