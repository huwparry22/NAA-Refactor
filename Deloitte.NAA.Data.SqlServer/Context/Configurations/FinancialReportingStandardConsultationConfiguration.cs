using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class FinancialReportingStandardConsultationConfiguration : IEntityTypeConfiguration<FinancialReportingStandardConsultation>
    {
        public void Configure(EntityTypeBuilder<FinancialReportingStandardConsultation> builder)
        {
            builder.Property(e => e.CceconsultationId)
                    .IsRequired()
                    .HasColumnName("CCEConsultationId")
                    .HasMaxLength(50);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.HasOne(d => d.Cceconsultation)
                .WithMany(p => p.FinancialReportingStandardConsultation)
                .HasForeignKey(d => d.CceconsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FinancialReportingStandardConsultation_CCEConsultation");
        }
    }
}
