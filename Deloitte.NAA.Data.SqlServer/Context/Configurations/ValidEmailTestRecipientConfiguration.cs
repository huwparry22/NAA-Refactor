using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ValidEmailTestRecipientConfiguration : IEntityTypeConfiguration<ValidEmailTestRecipient>
    {
        public void Configure(EntityTypeBuilder<ValidEmailTestRecipient> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
