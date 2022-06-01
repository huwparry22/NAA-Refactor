using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewStateCategoryConfiguration : IEntityTypeConfiguration<ViewStateCategory>
    {
        public void Configure(EntityTypeBuilder<ViewStateCategory> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_StateCategory");

            builder.Property(e => e.StateId).HasColumnName("StateID");

            builder.Property(e => e.Tag)
                .IsRequired()
                .HasMaxLength(9)
                .IsUnicode(false);
        }
    }
}
