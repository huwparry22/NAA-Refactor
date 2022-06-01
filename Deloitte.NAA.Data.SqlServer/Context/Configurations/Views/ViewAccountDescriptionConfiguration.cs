using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewAccountDescriptionConfiguration : IEntityTypeConfiguration<ViewAccountDescription>
    {
        public void Configure(EntityTypeBuilder<ViewAccountDescription> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_AccountDescription");

            builder.Property(e => e.AccountingConsultationId)
                .IsRequired()
                .HasColumnName("AccountingConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
