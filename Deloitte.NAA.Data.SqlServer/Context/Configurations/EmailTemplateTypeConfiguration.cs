using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EmailTemplateTypeConfiguration : IEntityTypeConfiguration<EmailTemplateType>
    {
        public void Configure(EntityTypeBuilder<EmailTemplateType> builder)
        {
            builder.Property(e => e.EmailTemplateTypeId)
                    .HasColumnName("EmailTemplateTypeID")
                    .ValueGeneratedNever();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.OfflineEmailActionWords)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.OperationName)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'None')");
        }
    }
}
