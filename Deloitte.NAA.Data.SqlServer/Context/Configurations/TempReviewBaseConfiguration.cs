using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class TempReviewBaseConfiguration : IEntityTypeConfiguration<TempReviewBase>
    {
        public void Configure(EntityTypeBuilder<TempReviewBase> builder)
        {
            builder.HasKey(e => e.ReviewBaseId)
                    .HasName("PK_ReviewBaseID1");

            builder.ToTable("Temp_ReviewBase");

            builder.Property(e => e.ReviewBaseId)
                .HasColumnName("ReviewBaseID")
                .ValueGeneratedNever();

            builder.Property(e => e.ArmentityId)
                .HasColumnName("ARMEntityID")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.AssuranceType)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.AuditFees).HasColumnType("money");

            builder.Property(e => e.ClearanceDate).HasColumnType("datetime");

            builder.Property(e => e.ClearanceReason)
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.ClientType)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.ClientsBusiness)
                .HasMaxLength(75)
                .IsUnicode(false);

            builder.Property(e => e.CountryOfIncorporation)
                .HasMaxLength(5)
                .IsUnicode(false);

            builder.Property(e => e.CreatedUsingMultipleDr).HasColumnName("CreatedUsingMultipleDR");

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.DateReviewRequiredBy).HasColumnType("datetime");

            builder.Property(e => e.Dunsnumber)
                .HasColumnName("DUNSNumber")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Emsengagement).HasColumnName("EMSEngagement");

            builder.Property(e => e.EngAcceptanceDate).HasColumnType("datetime");

            builder.Property(e => e.EntityName)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.FinancialYearEnd).HasColumnType("datetime");

            builder.Property(e => e.Gaapid).HasColumnName("GAAPID");

            builder.Property(e => e.InitialAcceptanceDate).HasColumnType("datetime");

            builder.Property(e => e.InitialAuditReportDate).HasColumnType("datetime");

            builder.Property(e => e.InitialAuditReportYear).HasColumnType("datetime");

            builder.Property(e => e.IsRelatedToSecregistrant).HasColumnName("IsRelatedToSECRegistrant");

            builder.Property(e => e.IsSecregistrant).HasColumnName("IsSECRegistrant");

            builder.Property(e => e.LocalBusinessId)
                .HasColumnName("LocalBusinessID")
                .HasMaxLength(100);

            builder.Property(e => e.MarketListings)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.OtherInformation)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.OtherKeyDates)
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.OtherReviewInformation)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.OwningDttlmemberFirm)
                .HasColumnName("OwningDTTLMemberFirm")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.OwningOfficeId).HasColumnName("OwningOfficeID");

            builder.Property(e => e.PreferredReviewerReason)
                .HasMaxLength(75)
                .IsUnicode(false);

            builder.Property(e => e.PreferredReviewerUserId).HasColumnName("PreferredReviewerUserID");

            builder.Property(e => e.PreviousReviewer)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.PsrfileAssemblyDate)
                .HasColumnName("PSRFileAssemblyDate")
                .HasColumnType("datetime");

            builder.Property(e => e.ReasonForQualification)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.RejectionReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.ReportingDate).HasColumnType("datetime");

            builder.Property(e => e.RequiredUsgaapknowledge).HasColumnName("RequiredUSGAAPKnowledge");

            builder.Property(e => e.ReviewBaseRowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.ReviewConfirmedDate).HasColumnType("datetime");

            builder.Property(e => e.ReviewLanguageId).HasColumnName("ReviewLanguageID");

            builder.Property(e => e.ReviewOfficeId).HasColumnName("ReviewOfficeID");

            builder.Property(e => e.ReviewPreferredDate).HasColumnType("datetime");

            builder.Property(e => e.Secrelationship).HasColumnName("SECRelationship");

            builder.Property(e => e.Sector).HasMaxLength(50);

            builder.Property(e => e.StateChangedByUserId).HasColumnName("StateChangedByUserID");

            builder.Property(e => e.StateChangedDate).HasColumnType("datetime");

            builder.Property(e => e.TypeOfAuditAssuranceOpinion)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Uhcdunsnumber)
                .HasColumnName("UHCDUNSNumber")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Uhcname)
                .HasColumnName("UHCName")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.VersionNumber).HasDefaultValueSql("((1))");

            builder.Property(e => e.Wbs3number)
                .HasColumnName("WBS3Number")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.WfemailLog)
                .HasColumnName("WFEmailLog")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.WithdrawalReason)
                .HasMaxLength(2000)
                .IsUnicode(false);
        }
    }
}
