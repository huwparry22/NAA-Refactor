using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewPointCommentConfiguration : IEntityTypeConfiguration<ReviewPointComment>
    {
        public void Configure(EntityTypeBuilder<ReviewPointComment> builder)
        {
            builder.HasIndex(e => e.CommentByReviewUserId);

            builder.HasIndex(e => e.ResponseByReviewerUserId);

            builder.HasIndex(e => e.ReviewPointId);

            builder.Property(e => e.ReviewPointCommentId).HasColumnName("ReviewPointCommentID");

            builder.Property(e => e.Comment)
                .IsRequired()
                .HasMaxLength(2048)
                .IsUnicode(false);

            builder.Property(e => e.CommentByReviewUserId).HasColumnName("CommentByReviewUserID");

            builder.Property(e => e.Response)
                .HasMaxLength(2048)
                .IsUnicode(false);

            builder.Property(e => e.ResponseByReviewerUserId).HasColumnName("ResponseByReviewerUserID");

            builder.Property(e => e.ReviewPointId).HasColumnName("ReviewPointID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.CommentByReviewUser)
                .WithMany(p => p.ReviewPointCommentCommentByReviewUser)
                .HasForeignKey(d => d.CommentByReviewUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewPointComment_User");

            builder.HasOne(d => d.ResponseByReviewerUser)
                .WithMany(p => p.ReviewPointCommentResponseByReviewerUser)
                .HasForeignKey(d => d.ResponseByReviewerUserId)
                .HasConstraintName("FK_ReviewPointComment_ResponseUser");

            builder.HasOne(d => d.ReviewPoint)
                .WithMany(p => p.ReviewPointComment)
                .HasForeignKey(d => d.ReviewPointId)
                .HasConstraintName("FK_ReviewComment_ReviewPoint");
        }
    }
}
