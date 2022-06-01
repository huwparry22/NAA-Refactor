using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewBitStateTextConfiguration : IEntityTypeConfiguration<ViewBitStateText>
    {
        public void Configure(EntityTypeBuilder<ViewBitStateText> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_BitStateText");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            builder.Property(e => e.StateId).HasColumnName("StateID");
        }
    }
}
