using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EmailRecipientRoleConfiguration : IEntityTypeConfiguration<EmailRecipientRole>
    {
        public void Configure(EntityTypeBuilder<EmailRecipientRole> builder)
        {
            builder.HasKey(e => e.EmailRoleId)
                    .HasName("PK_EmailRole");

            builder.HasIndex(e => e.EmailRecipientId);

            builder.HasIndex(e => e.ReviewerTypeId);

            builder.Property(e => e.EmailRoleId).HasColumnName("EmailRoleID");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.EmailRecipientId).HasColumnName("EmailRecipientID");

            builder.Property(e => e.ReviewerTypeId).HasColumnName("ReviewerTypeID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.EmailRecipient)
                .WithMany(p => p.EmailRecipientRole)
                .HasForeignKey(d => d.EmailRecipientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailRecipientRole_EmailRecipient");

            builder.HasOne(d => d.ReviewerType)
                .WithMany(p => p.EmailRecipientRole)
                .HasForeignKey(d => d.ReviewerTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailRecipientRole_ReviewerType");
        }
    }
}
