using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EarConsultationConfiguration : IEntityTypeConfiguration<EarConsultation>
    {
        public void Configure(EntityTypeBuilder<EarConsultation> builder)
        {
            builder.ToTable("EARConsultation");

            //builder.HasIndex(e => e.ReviewBaseId)
            //    .HasName("IDX_EARConsultation:Composite5418");

            builder.Property(e => e.EarconsultationId)
                .HasColumnName("EARConsultationID")
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'EAR_'+CONVERT([nvarchar](50),NEXT VALUE FOR [dbo].[EARConsultationIDSeq],(0)))");

            builder.Property(e => e.AuditReportSigningDate).HasColumnType("datetime");

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.DateEarreviewRequestedBy)
                .HasColumnName("DateEARReviewRequestedBy")
                .HasColumnType("datetime");

            builder.Property(e => e.DiscussionLowReviewEngtTeamCleared)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.DiscussionMediumReviewEngTeamCleared)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.EpsignoffBy).HasColumnName("EPSignoffBy");

            builder.Property(e => e.EpsignoffDateTime)
                .HasColumnName("EPSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.FactsAndCircumstancesOfQuery).HasMaxLength(4000);

            builder.Property(e => e.Gaap).HasColumnName("GAAP");

            builder.Property(e => e.IsDiscussedWithNaateam)
                .HasColumnName("IsDiscussedWithNAATeam")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.IsFirstYearofPreparingEar).HasColumnName("IsFirstYearofPreparingEAR");

            builder.Property(e => e.IsRelatedtoMorethanOneEntity).HasDefaultValueSql("((0))");

            builder.Property(e => e.IsRiskTableIncluded).HasDefaultValueSql("((0))");

            builder.Property(e => e.NaapartnerSignoffBy).HasColumnName("NAAPartnerSignoffBy");

            builder.Property(e => e.NaapartnerSignoffDateTime)
                .HasColumnName("NAAPartnerSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.NameofEntities).HasMaxLength(4000);

            builder.Property(e => e.NameofNaateamMember)
                .HasColumnName("NameofNAATeamMember")
                .HasMaxLength(500);

            builder.Property(e => e.Notes).HasMaxLength(200);

            builder.Property(e => e.PriorityId).HasColumnName("PriorityID");

            builder.Property(e => e.PriorityReason).HasMaxLength(200);

            builder.Property(e => e.QueryDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.ReasonForEar).HasColumnName("ReasonForEAR");

            builder.Property(e => e.RejectionReason).HasMaxLength(2000);

            builder.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.StateChangedByUserId).HasColumnName("StateChangedByUserID");

            builder.Property(e => e.StateChangedDate).HasColumnType("datetime");

            builder.Property(e => e.WithdrawalApprovalReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.WithdrawalReason).HasMaxLength(2000);

            builder.HasOne(d => d.CurrentState)
                .WithMany(p => p.Earconsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EARConsultation_State");

            builder.HasOne(d => d.EpsignoffByNavigation)
                .WithMany(p => p.EarconsultationEpsignoffByNavigation)
                .HasForeignKey(d => d.EpsignoffBy)
                .HasConstraintName("FK_EARConsultation_User");

            builder.HasOne(d => d.NaapartnerSignoffByNavigation)
                .WithMany(p => p.EarconsultationNaapartnerSignoffByNavigation)
                .HasForeignKey(d => d.NaapartnerSignoffBy)
                .HasConstraintName("FK_EARConsultation_User2");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.Earconsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EARConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.EarconsultationStateChangedByUser)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EARConsultation_User1");
        }
    }
}
