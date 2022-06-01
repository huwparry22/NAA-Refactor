using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            //builder.HasIndex(e => new { e.UserId, e.MemberFirmId, e.SystemRoleId })
            //        .HasName("IX_UserRole")
            //        .IsUnique();

            builder.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

            builder.Property(e => e.MemberFirmId)
                .HasColumnName("MemberFirmID")
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.UserRole)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_MemberFirm");

            builder.HasOne(d => d.SystemRole)
                .WithMany(p => p.UserRole)
                .HasForeignKey(d => d.SystemRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_Role");

            builder.HasOne(d => d.User)
                .WithMany(p => p.UserRole)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRole_User");
        }
    }
}
