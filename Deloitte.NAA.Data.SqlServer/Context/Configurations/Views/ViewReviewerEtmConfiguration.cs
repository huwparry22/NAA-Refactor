using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewReviewerEtmConfiguration : IEntityTypeConfiguration<ViewReviewerEtm>
    {
        public void Configure(EntityTypeBuilder<ViewReviewerEtm> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ReviewerETM");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.Etm)
                .HasColumnName("ETM")
                .HasMaxLength(153);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");
        }
    }
}
