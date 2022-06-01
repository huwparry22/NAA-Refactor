using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class CoreDataEmployeeConfiguration : IEntityTypeConfiguration<CoreDataEmployee>
    {
        public void Configure(EntityTypeBuilder<CoreDataEmployee> builder)
        {
            builder.HasNoKey();

            builder.ToView("CoreData_Employee");

            builder.Property(e => e.ActiveDirectoryDisplayName).HasMaxLength(100);

            builder.Property(e => e.ActiveDirectoryId)
                .HasColumnName("ActiveDirectoryID")
                .HasMaxLength(36)
                .IsUnicode(false);

            builder.Property(e => e.DomainName).HasMaxLength(50);

            builder.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.EmployeeStatus).HasMaxLength(25);

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Grade).HasMaxLength(10);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LegalLocationCity).HasMaxLength(50);

            builder.Property(e => e.LoginName).HasMaxLength(50);

            builder.Property(e => e.MiddleInitials).HasMaxLength(10);

            builder.Property(e => e.OfficeCity).HasMaxLength(50);

            builder.Property(e => e.OfficeCountryCode)
                .HasMaxLength(2)
                .IsUnicode(false);

            builder.Property(e => e.OfficeLocationCode).HasMaxLength(25);

            builder.Property(e => e.Phone)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.PositionTitleText).HasMaxLength(50);

            builder.Property(e => e.SappersonnelNo)
                .IsRequired()
                .HasColumnName("SAPPersonnelNo")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.SearchFirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.SearchFirstNameSoundex)
                .IsRequired()
                .HasMaxLength(4)
                .IsFixedLength();

            builder.Property(e => e.SearchLastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.SearchLastNameSoundex)
                .IsRequired()
                .HasMaxLength(4)
                .IsFixedLength();

            builder.Property(e => e.ServiceLineText)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
