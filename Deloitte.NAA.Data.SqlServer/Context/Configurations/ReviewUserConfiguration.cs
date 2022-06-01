using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewUserConfiguration : IEntityTypeConfiguration<ReviewUser>
    {
        public void Configure(EntityTypeBuilder<ReviewUser> builder)
        {
            builder.HasIndex(e => e.ReviewBaseId);

            builder.HasIndex(e => e.ReviewerTypeId);

            builder.HasIndex(e => e.SignedOffByUserId);

            builder.HasIndex(e => e.UserId);

            //builder.HasIndex(e => new { e.UserId, e.EndTime })
            //    .HasName("IDX_ReviewUser:Composite13663");

            //builder.HasIndex(e => new { e.ReviewBaseId, e.UserId, e.ReviewerTypeId, e.EndTime })
            //    .HasName("IDX_ReviewUser:Composite107679");

            builder.Property(e => e.ReviewUserId).HasColumnName("ReviewUserID");

            builder.Property(e => e.ApprovedDate).HasColumnType("datetime");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.EndTime).HasColumnType("datetime");

            builder.Property(e => e.Independence).HasColumnType("datetime");

            builder.Property(e => e.Position).HasMaxLength(100);

            builder.Property(e => e.Required).HasDefaultValueSql("((0))");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.SignedOffByUserId).HasColumnName("SignedOffByUserID");

            builder.Property(e => e.StartTime).HasColumnType("datetime");

            builder.Property(e => e.TimeSpent).HasColumnType("decimal(10, 2)");

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.ReviewUser)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewUser_ReviewBase");

            builder.HasOne(d => d.ReviewerType)
                .WithMany(p => p.ReviewUser)
                .HasForeignKey(d => d.ReviewerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewUser_ReviewerType");

            builder.HasOne(d => d.SignedOffByUser)
                .WithMany(p => p.ReviewUserSignedOffByUser)
                .HasForeignKey(d => d.SignedOffByUserId)
                .HasConstraintName("FK_ReviewUser_User2");

            builder.HasOne(d => d.User)
                .WithMany(p => p.ReviewUserUser)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewUser_User");
        }
    }
}
