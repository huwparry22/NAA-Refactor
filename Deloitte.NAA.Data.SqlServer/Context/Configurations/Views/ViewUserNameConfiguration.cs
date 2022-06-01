using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewUserNameConfiguration : IEntityTypeConfiguration<ViewUserName>
    {
        public void Configure(EntityTypeBuilder<ViewUserName> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_UserName");

            builder.Property(e => e.FullName).HasMaxLength(153);

            builder.Property(e => e.UserId)
                .HasColumnName("UserID")
                .ValueGeneratedOnAdd();
        }
    }
}
