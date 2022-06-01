using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewPreviewConsultationConfiguration : IEntityTypeConfiguration<ViewPreviewConsultation>
    {
        public void Configure(EntityTypeBuilder<ViewPreviewConsultation> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_PreviewConsultation");

            builder.Property(e => e.ChangeDate).HasColumnType("datetime");

            builder.Property(e => e.ConsultationId)
                .HasColumnName("ConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.EntityName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.MemberFirmId).HasColumnName("MemberFirmID");

            builder.Property(e => e.Notes).HasMaxLength(200);

            builder.Property(e => e.PriorityId).HasColumnName("PriorityID");

            builder.Property(e => e.QueryDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.StateId).HasColumnName("StateID");

            builder.Property(e => e.StateText)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
