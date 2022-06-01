using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewRiskRatingConfiguration : IEntityTypeConfiguration<ViewRiskRating>
    {
        public void Configure(EntityTypeBuilder<ViewRiskRating> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_RiskRating");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);

            builder.Property(e => e.RiskRatingId).HasColumnName("RiskRatingID");
        }
    }
}
