using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CorpReportingSubjectMatterConfiguration : IEntityTypeConfiguration<CorpReportingSubjectMatter>
    {
        public void Configure(EntityTypeBuilder<CorpReportingSubjectMatter> builder)
        {
            builder.HasKey(e => e.SubjectMatterId);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.IsGaap).HasColumnName("isGAAP");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
