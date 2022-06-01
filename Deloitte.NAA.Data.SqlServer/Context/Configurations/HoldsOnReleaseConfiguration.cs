using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class HoldsOnReleaseConfiguration : IEntityTypeConfiguration<HoldsOnRelease>
    {
        public void Configure(EntityTypeBuilder<HoldsOnRelease> builder)
        {
            builder.HasIndex(e => e.CategoryId);

            builder.HasIndex(e => e.ReviewBaseId);

            builder.HasIndex(e => e.UserId);

            builder.Property(e => e.HoldsOnReleaseId).HasColumnName("HoldsOnReleaseID");

            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Response)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.HoldsOnRelease)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoldsOnRelease_ReviewBase");

            builder.HasOne(d => d.User)
                .WithMany(p => p.HoldsOnRelease)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_HoldsOnRelease_User");
        }
    }
}
