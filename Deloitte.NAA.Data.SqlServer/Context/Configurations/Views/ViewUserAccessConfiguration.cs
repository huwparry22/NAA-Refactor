using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewUserAccessConfiguration : IEntityTypeConfiguration<ViewUserAccess>
    {
        public void Configure(EntityTypeBuilder<ViewUserAccess> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_UserAccess");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.UserId).HasColumnName("UserID");
        }
    }
}
