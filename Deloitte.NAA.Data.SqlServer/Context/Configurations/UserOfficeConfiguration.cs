using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UserOfficeConfiguration : IEntityTypeConfiguration<UserOffice>
    {
        public void Configure(EntityTypeBuilder<UserOffice> builder)
        {
            //builder.HasIndex(e => new { e.UserId, e.OfficeId })
            //        .HasName("IX_UserOffice_UserIDOfficeID");

            builder.Property(e => e.UserOfficeId).HasColumnName("UserOfficeID");

            builder.Property(e => e.OfficeId).HasColumnName("OfficeID");

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.Office)
                .WithMany(p => p.UserOffice)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserOffice_Office");

            builder.HasOne(d => d.User)
                .WithMany(p => p.UserOffice)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserOffice_User");
        }
    }
}
