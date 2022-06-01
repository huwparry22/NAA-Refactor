using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.Property(e => e.AuditLogId).HasColumnName("AuditLogID");

            builder.Property(e => e.AuditDetail).HasMaxLength(4000);

            builder.Property(e => e.AuditTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.AuditUserId).HasColumnName("AuditUserID");

            builder.Property(e => e.SqlprocessId).HasColumnName("SQLProcessID");

            builder.Property(e => e.SqluserName)
                .HasColumnName("SQLUserName")
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
        }
    }
}
