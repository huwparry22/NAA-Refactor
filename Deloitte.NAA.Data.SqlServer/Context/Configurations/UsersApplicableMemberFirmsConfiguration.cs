using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UsersApplicableMemberFirmsConfiguration : IEntityTypeConfiguration<UsersApplicableMemberFirms>
    {
        public void Configure(EntityTypeBuilder<UsersApplicableMemberFirms> builder)
        {
            builder.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.UsersApplicableMemberFirms)
                .HasForeignKey(d => d.MemberFirmId)
                .HasConstraintName("FK_UsersApplicableMemberFirms_MemberFirm");

            builder.HasOne(d => d.User)
                .WithMany(p => p.UsersApplicableMemberFirms)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UsersApplicableMemberFirms_User");
        }
    }
}
