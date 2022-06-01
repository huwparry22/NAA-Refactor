using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CceConsultationConfiguration : IEntityTypeConfiguration<CceConsultation>
    {
        public void Configure(EntityTypeBuilder<CceConsultation> builder)
        {
            builder.ToTable("CCEConsultation");

            builder.Property(e => e.CceconsultationId)
                .HasColumnName("CCEConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.AqmmilestoneDeadline)
                .HasColumnName("AQMMilestoneDeadline")
                .HasColumnType("datetime");

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.EngagementTypeId).HasColumnName("EngagementTypeID");

            builder.Property(e => e.EpsignoffBy).HasColumnName("EPSignoffBy");

            builder.Property(e => e.EpsignoffDateTime)
                .HasColumnName("EPSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.EqcrsignoffBy).HasColumnName("EQCRSignoffBy");

            builder.Property(e => e.EqcrsignoffDateTime)
                .HasColumnName("EQCRSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.IsDiscussedWithNaateam)
                .HasColumnName("IsDiscussedWithNAATeam")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.IsRelatedtoMorethanOneEntity).HasDefaultValueSql("((0))");

            builder.Property(e => e.Llpaccreditation).HasColumnName("LLPAccreditation");

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

            builder.Property(e => e.RejectionReason).HasMaxLength(2000);

            builder.Property(e => e.ReportingDeadline).HasColumnType("datetime");

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
                .WithMany(p => p.Cceconsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CCEConsultation_State");

            builder.HasOne(d => d.EpsignoffByNavigation)
                .WithMany(p => p.CceconsultationEpsignoffByNavigation)
                .HasForeignKey(d => d.EpsignoffBy)
                .HasConstraintName("FK_CCEConsultation_User1");

            builder.HasOne(d => d.EqcrsignoffByNavigation)
                .WithMany(p => p.CceconsultationEqcrsignoffByNavigation)
                .HasForeignKey(d => d.EqcrsignoffBy)
                .HasConstraintName("FK_CCEConsultation_User3");

            builder.HasOne(d => d.NaapartnerSignoffByNavigation)
                .WithMany(p => p.CceconsultationNaapartnerSignoffByNavigation)
                .HasForeignKey(d => d.NaapartnerSignoffBy)
                .HasConstraintName("FK_CCEConsultation_User2");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.Cceconsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CCEConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.CceconsultationStateChangedByUser)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CCEConsultation_User");
        }
    }
}
