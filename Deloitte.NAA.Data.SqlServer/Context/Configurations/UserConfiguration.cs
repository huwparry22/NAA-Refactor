using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(e => e.SappersonnelNo);

            builder.HasIndex(e => e.SearchName);

            //builder.HasIndex(e => new { e.Lastname, e.Firstname })
            //    .HasName("IX_User_LastnameFirstname");

            //builder.HasIndex(e => new { e.LoginName, e.DomainName })
            //    .HasName("IX_User_LoginNameDomainName");

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.Property(e => e.ActiveDirectoryId)
                .HasColumnName("ActiveDirectoryID")
                .HasMaxLength(36)
                .IsUnicode(false);

            builder.Property(e => e.ChargePerHour).HasColumnType("decimal(10, 2)");

            builder.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.CurrentConsultationType).HasMaxLength(50);

            builder.Property(e => e.CurrentView).HasMaxLength(50);

            builder.Property(e => e.DomainName).HasMaxLength(50);

            builder.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.Firstname).HasMaxLength(50);

            builder.Property(e => e.Grade).HasMaxLength(50);

            builder.Property(e => e.LastLoggedIn).HasColumnType("datetime");

            builder.Property(e => e.Lastname).HasMaxLength(50);

            builder.Property(e => e.LoginName).HasMaxLength(50);

            builder.Property(e => e.MiddleName).HasMaxLength(50);

            builder.Property(e => e.OfficeId).HasColumnName("OfficeID");

            builder.Property(e => e.PageSize).HasDefaultValueSql("((15))");

            builder.Property(e => e.Phone)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.PositionTitle).HasMaxLength(100);

            builder.Property(e => e.SappersonnelNo)
                .HasColumnName("SAPPersonnelNo")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.SearchName).HasMaxLength(200);

            builder.Property(e => e.ServiceLine).HasMaxLength(50);

            builder.Property(e => e.SortColumn)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Timestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
