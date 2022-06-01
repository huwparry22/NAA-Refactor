using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewComplexityTextConfiguration : IEntityTypeConfiguration<ViewComplexityText>
    {
        public void Configure(EntityTypeBuilder<ViewComplexityText> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ComplexityText");

            builder.Property(e => e.ComplexityId).HasColumnName("ComplexityID");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);
        }
    }
}
