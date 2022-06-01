using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UserConsultationTypeConfiguration : IEntityTypeConfiguration<UserConsultationType>
    {
        public void Configure(EntityTypeBuilder<UserConsultationType> builder)
        {
            builder.Property(e => e.UserConsultationTypeId).HasColumnName("UserConsultationTypeID");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.MemberFirmId)
                .HasColumnName("MemberFirmID")
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.UserConsultationType)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserConsultationType_MemberFirm");

            builder.HasOne(d => d.User)
                .WithMany(p => p.UserConsultationType)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserConsultationType_User");
        }
    }
}
