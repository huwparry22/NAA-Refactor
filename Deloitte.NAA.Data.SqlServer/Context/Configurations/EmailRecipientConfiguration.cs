using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EmailRecipientConfiguration : IEntityTypeConfiguration<EmailRecipient>
    {
        public void Configure(EntityTypeBuilder<EmailRecipient> builder)
        {
            builder.HasIndex(e => e.EmailId);

            //builder.HasIndex(e => e.Guid)
            //    .HasName("IDX_EmailRecipient:Composite24647");

            builder.Property(e => e.EmailRecipientId).HasColumnName("EmailRecipientID");

            builder.Property(e => e.CcuserEmail)
                .HasColumnName("CCUserEmail")
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.EmailId).HasColumnName("EmailID");

            builder.Property(e => e.Guid).HasDefaultValueSql("(newid())");

            builder.Property(e => e.IsTo)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.UserId).HasColumnName("UserID");

            builder.HasOne(d => d.Email)
                .WithMany(p => p.EmailRecipient)
                .HasForeignKey(d => d.EmailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailRecipient_Email");

            builder.HasOne(d => d.User)
                .WithMany(p => p.EmailRecipient)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailRecipient_User");
        }
    }
}
