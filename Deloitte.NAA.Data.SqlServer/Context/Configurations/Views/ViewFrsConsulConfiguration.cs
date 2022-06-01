using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewFrsConsulConfiguration : IEntityTypeConfiguration<ViewFrsConsul>
    {
        public void Configure(EntityTypeBuilder<ViewFrsConsul> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_FRSConsul");

            builder.Property(e => e.CceconsultationId)
                .IsRequired()
                .HasColumnName("CCEConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
