using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class SystemRoleStatePriviledgeConfiguration : IEntityTypeConfiguration<SystemRoleStatePriviledge>
    {
        public void Configure(EntityTypeBuilder<SystemRoleStatePriviledge> builder)
        {
            builder.HasKey(e => e.StatePriviledgeId)
                    .HasName("PK_StatePriviledge");

            builder.Property(e => e.StatePriviledgeId).HasColumnName("StatePriviledgeID");

            builder.Property(e => e.PriviledgeId).HasColumnName("PriviledgeID");

            builder.Property(e => e.StateId).HasColumnName("StateID");

            builder.Property(e => e.SystemRoleId).HasColumnName("SystemRoleID");

            builder.HasOne(d => d.Priviledge)
                .WithMany(p => p.SystemRoleStatePriviledge)
                .HasForeignKey(d => d.PriviledgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatePriviledge_Priviledge");

            builder.HasOne(d => d.State)
                .WithMany(p => p.SystemRoleStatePriviledge)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatePriviledge_State");

            builder.HasOne(d => d.SystemRole)
                .WithMany(p => p.SystemRoleStatePriviledge)
                .HasForeignKey(d => d.SystemRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatePriviledge_Role");
        }
    }
}
