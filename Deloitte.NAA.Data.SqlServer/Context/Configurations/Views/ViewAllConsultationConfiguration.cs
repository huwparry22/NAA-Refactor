using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewAllConsultationConfiguration : IEntityTypeConfiguration<ViewAllConsultation>
    {
        public void Configure(EntityTypeBuilder<ViewAllConsultation> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_AllConsultation");

            builder.Property(e => e.ChangeDate).HasColumnType("datetime");

            builder.Property(e => e.ConsultationId)
                .HasColumnName("ConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Notes).HasMaxLength(200);

            builder.Property(e => e.PriorityId).HasColumnName("PriorityID");

            builder.Property(e => e.PriorityReason).HasMaxLength(200);

            builder.Property(e => e.QueryDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.StateId).HasColumnName("StateID");
        }
    }
}
