using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class SubjectMatterConfiguration : IEntityTypeConfiguration<SubjectMatter>
    {
        public void Configure(EntityTypeBuilder<SubjectMatter> builder)
        {
            //builder.HasIndex(e => new { e.SubjectMatterId, e.ConsultationTypeId })
            //        .HasName("ConsultationType_SubjectMatter");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.ConsultationType)
                .WithMany(p => p.SubjectMatter)
                .HasForeignKey(d => d.ConsultationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubjectMatter_NAAConsultation");
        }
    }
}
