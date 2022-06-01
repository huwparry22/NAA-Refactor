using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DelinquentConsultationConfiguration : IEntityTypeConfiguration<DelinquentConsultation>
    {
        public void Configure(EntityTypeBuilder<DelinquentConsultation> builder)
        {
            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.ConsultationTypeId)
                .HasMaxLength(50)
                .IsFixedLength();

            builder.Property(e => e.DelinquentConsultationNoOfDaysStayed).HasColumnName("DelinquentConsultation_NoOfDaysStayed");

            builder.Property(e => e.DelinquentEmailSent)
                .HasColumnName("Delinquent_EmailSent")
                .HasColumnType("datetime");

            builder.Property(e => e.DelinquentExplanation).HasColumnName("Delinquent_Explanation");

            builder.Property(e => e.DelinquentFlag).HasColumnName("Delinquent_Flag");

            builder.Property(e => e.DelinquentReviewStatus).HasColumnName("Delinquent_ReviewStatus");

            builder.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.SlowConsultationEmailSent)
                .HasColumnName("SlowConsultation_EmailSent")
                .HasColumnType("datetime");

            builder.Property(e => e.SlowConsultationFlag).HasColumnName("SlowConsultation_Flag");

            builder.Property(e => e.SlowConsultationNoOfDaysStayed).HasColumnName("SlowConsultation_NoOfDaysStayed");

            builder.Property(e => e.SlowConsultationReviewStatus).HasColumnName("SlowConsultation_ReviewStatus");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.DelinquentConsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .HasConstraintName("FK_DelinquentConsultation_ReviewBase");
        }
    }
}
