using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UserSpecialistConfiguration : IEntityTypeConfiguration<UserSpecialist>
    {
        public void Configure(EntityTypeBuilder<UserSpecialist> builder)
        {
            builder.Property(e => e.UserSpecialistId).HasColumnName("UserSpecialistID");

            builder.Property(e => e.MemberFirmId).HasColumnName("MemberFirmID");

            builder.Property(e => e.SpecialistId).HasColumnName("SpecialistID");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
