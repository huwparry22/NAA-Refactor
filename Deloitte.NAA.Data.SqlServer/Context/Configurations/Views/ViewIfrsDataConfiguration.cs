using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewIfrsDataConfiguration : IEntityTypeConfiguration<ViewIfrsData>
    {
        public void Configure(EntityTypeBuilder<ViewIfrsData> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_IFRSData");

            builder.Property(e => e.AccountingConsultationId)
                .IsRequired()
                .HasColumnName("AccountingConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Category)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.SubCategory)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
