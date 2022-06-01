using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewerTypeStatePriviledgeConfiguration : IEntityTypeConfiguration<ReviewerTypeStatePriviledge>
    {
        public void Configure(EntityTypeBuilder<ReviewerTypeStatePriviledge> builder)
        {
            builder.Property(e => e.ReviewerTypeStatePriviledgeId).HasColumnName("ReviewerTypeStatePriviledgeID");

            builder.Property(e => e.PriviledgeId).HasColumnName("PriviledgeID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.StateId).HasColumnName("StateID");

            builder.HasOne(d => d.Priviledge)
                .WithMany(p => p.ReviewerTypeStatePriviledge)
                .HasForeignKey(d => d.PriviledgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewerTypeStatePriviledge_Priviledge");

            builder.HasOne(d => d.ReviewerType)
                .WithMany(p => p.ReviewerTypeStatePriviledge)
                .HasForeignKey(d => d.ReviewerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewerTypeStatePriviledge_ReviewerType");

            builder.HasOne(d => d.State)
                .WithMany(p => p.ReviewerTypeStatePriviledge)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewerTypeStatePriviledge_State");
        }
    }
}
