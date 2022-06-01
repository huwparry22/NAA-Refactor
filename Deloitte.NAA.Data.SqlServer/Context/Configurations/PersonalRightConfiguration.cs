using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PersonalRightConfiguration : IEntityTypeConfiguration<PersonalRight>
    {
        public void Configure(EntityTypeBuilder<PersonalRight> builder)
        {
            builder.Property(e => e.PersonalRightId).HasColumnName("PersonalRightID");

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

            builder.HasOne(d => d.User)
                .WithMany(p => p.PersonalRight)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonalRight_User");

            builder.HasOne(d => d.UserRole)
                .WithMany(p => p.PersonalRight)
                .HasForeignKey(d => d.UserRoleId)
                .HasConstraintName("FK_PersonalRight_UserRole");
        }
    }
}
