using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class AuditConsultationConfiguration : IEntityTypeConfiguration<AuditConsultation>
    {
        public void Configure(EntityTypeBuilder<AuditConsultation> builder)
        {
            //builder.HasIndex(e => e.ReviewBaseId)
            //        .HasName("ReviewBaseID");

            //builder.HasIndex(e => new { e.ReviewBaseId, e.PriorityId })
            //    .HasName("IDX_AuditConsultation:Composite5412");

            //builder.HasIndex(e => new { e.AuditConsultationId, e.ReviewBaseId, e.CurrentStateId, e.ChaserEmail, e.ChaserEmailUpdateDate })
            //    .HasName("IDX_AuditConsultation:Composite8899");

            //builder.HasIndex(e => new { e.ReviewBaseId, e.QueryDescription, e.RelevantProfessionalStandards, e.StateChangedDate, e.PriorityId, e.Notes, e.CurrentStateId })
            //    .HasName("IDX_AuditConsultation:Composite23461");

            builder.Property(e => e.AuditConsultationId)
                .HasColumnName("AuditConsultationID")
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Audit_'+CONVERT([nvarchar](50),NEXT VALUE FOR [dbo].[AuditConsultationIDSeq],(0)))");

            builder.Property(e => e.BasisoftheConsultationResponse).HasMaxLength(2000);

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.Conditions).HasMaxLength(2000);

            builder.Property(e => e.ConsultationResponse).HasMaxLength(2000);

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.DesiredCompletionDate).HasColumnType("datetime");

            builder.Property(e => e.EngagementTypeId).HasColumnName("EngagementTypeID");

            builder.Property(e => e.EpsignoffBy).HasColumnName("EPSignoffBy");

            builder.Property(e => e.EpsignoffDateTime)
                .HasColumnName("EPSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.EqcrsignoffBy).HasColumnName("EQCRSignoffBy");

            builder.Property(e => e.EqcrsignoffDateTime)
                .HasColumnName("EQCRSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.ExtensionLength)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FactsAndCircumstancesOfQuery).HasMaxLength(4000);

            builder.Property(e => e.IsDiscussedWithNaateam)
                .HasColumnName("IsDiscussedWithNAATeam")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.IsRelatedtoMorethanOneEntity).HasDefaultValueSql("((0))");

            builder.Property(e => e.KeyMilestoneDate).HasColumnType("datetime");

            builder.Property(e => e.NaapartnerSignoffBy).HasColumnName("NAAPartnerSignoffBy");

            builder.Property(e => e.NaapartnerSignoffDateTime)
                .HasColumnName("NAAPartnerSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.NameofEntities).HasMaxLength(4000);

            builder.Property(e => e.NameofNaateamMember)
                .HasColumnName("NameofNAATeamMember")
                .HasMaxLength(500);

            builder.Property(e => e.Notes).HasMaxLength(200);

            builder.Property(e => e.OtherConsultation).HasMaxLength(250);

            builder.Property(e => e.OtherRemarks).HasMaxLength(2000);

            builder.Property(e => e.PlannedSubmissionDate).HasColumnType("datetime");

            builder.Property(e => e.PreSignOffDateTime).HasColumnType("datetime");

            builder.Property(e => e.PriorityId).HasColumnName("PriorityID");

            builder.Property(e => e.PriorityReason).HasMaxLength(200);

            builder.Property(e => e.PsrlogNumber)
                .HasColumnName("PSRLogNumber")
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.QueryDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.References).HasMaxLength(2000);

            builder.Property(e => e.RejectionReason).HasMaxLength(2000);

            builder.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

            builder.Property(e => e.RequiredConsultationTypeId).HasColumnName("RequiredConsultationTypeID");

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
                .WithMany(p => p.AuditConsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditConsultation_State");

            builder.HasOne(d => d.EpsignoffByNavigation)
                .WithMany(p => p.AuditConsultationEpsignoffByNavigation)
                .HasForeignKey(d => d.EpsignoffBy)
                .HasConstraintName("FK_AuditConsultation_User1");

            builder.HasOne(d => d.EqcrsignoffByNavigation)
                .WithMany(p => p.AuditConsultationEqcrsignoffByNavigation)
                .HasForeignKey(d => d.EqcrsignoffBy)
                .HasConstraintName("FK_AuditConsultation_User3");

            builder.HasOne(d => d.NaapartnerSignoffByNavigation)
                .WithMany(p => p.AuditConsultationNaapartnerSignoffByNavigation)
                .HasForeignKey(d => d.NaapartnerSignoffBy)
                .HasConstraintName("FK_AuditConsultation_User2");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.AuditConsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.AuditConsultationStateChangedByUser)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditConsultation_User");
        }
    }
}
