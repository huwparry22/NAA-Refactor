using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewGroupCompanyTextConfiguration : IEntityTypeConfiguration<ViewGroupCompanyText>
    {
        public void Configure(EntityTypeBuilder<ViewGroupCompanyText> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_GroupCompanyText");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false);

            builder.Property(e => e.StateId).HasColumnName("StateID");
        }
    }
}
