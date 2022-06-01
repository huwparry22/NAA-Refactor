using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.Property(e => e.EmailId).HasColumnName("EmailID");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.Property(e => e.EmailBody).IsRequired();

            builder.Property(e => e.EmailNotificationId).HasColumnName("EmailNotificationID");

            builder.Property(e => e.EmailSubject)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.TemplateTypeId).HasColumnName("TemplateTypeID");

            builder.HasOne(d => d.EmailNotification)
                .WithMany(p => p.Email)
                .HasForeignKey(d => d.EmailNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Email_EmailNotification");

            builder.HasOne(d => d.TemplateType)
                .WithMany(p => p.Email)
                .HasForeignKey(d => d.TemplateTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Email_EmailTemplateType");
        }
    }
}
