using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class UserFicConfiguration : IEntityTypeConfiguration<UserFic>
    {
        public void Configure(EntityTypeBuilder<UserFic> builder)
        {
            builder.ToTable("UserFIC");

            builder.Property(e => e.UserFicid).HasColumnName("UserFICID");

            builder.Property(e => e.EndTime).HasColumnType("datetime");

            builder.Property(e => e.FicroleId).HasColumnName("FICRoleID");

            builder.Property(e => e.MemberFirmId).HasColumnName("MemberFirmID");

            builder.Property(e => e.StartTime).HasColumnType("datetime");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
