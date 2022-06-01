using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewReviewStateConfiguration : IEntityTypeConfiguration<ViewReviewState>
    {
        public void Configure(EntityTypeBuilder<ViewReviewState> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ReviewState");

            builder.Property(e => e.ChangeDate).HasColumnType("datetime");

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.StateId).HasColumnName("StateID");
        }
    }
}
