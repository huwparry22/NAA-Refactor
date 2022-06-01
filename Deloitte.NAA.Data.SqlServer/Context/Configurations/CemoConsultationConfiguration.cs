using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CemoConsultationConfiguration : IEntityTypeConfiguration<CemoConsultation>
    {
        public void Configure(EntityTypeBuilder<CemoConsultation> builder)
        {
            builder.ToTable("CEMOConsultation");

            builder.HasIndex(e => e.ReviewBaseId)
                .HasName("IDX_CEMOConsultation:Composite5416");

            builder.HasIndex(e => new { e.CemoconsultationId, e.ReviewBaseId })
                .HasName("IDX_CEMOConsultation:Composite103");

            builder.HasIndex(e => new { e.ReviewBaseId, e.CurrentStateId })
                .HasName("IDX_CEMOConsultation:Composite6217");

            builder.HasIndex(e => new { e.QueryDescription, e.StateChangedDate, e.PriorityId, e.Notes, e.ReviewBaseId, e.CurrentStateId })
                .HasName("IDX_CEMOConsultation:Composite6431");

            builder.HasIndex(e => new { e.CemoconsultationId, e.QueryDescription, e.AuditReportSigningDate, e.DateCemoreviewRequestedBy, e.ModifiedOpinionOnLastYearAuditReport, e.FactsAndCircumstancesOfQuery, e.RequestTypeId, e.DiscussionLowReviewEngtTeamCleared, e.DiscussionMediumReviewEngTeamCleared, e.DiffcultReviewEngtTeamCleared, e.EpsignoffBy, e.EpsignoffDateTime, e.IsRelatedtoMorethanOneEntity, e.NumberofEntities, e.NameofEntities, e.ReviewBaseId })
                .HasName("IDX_CEMOConsultation:Composite6428");

            builder.Property(e => e.CemoconsultationId)
                .HasColumnName("CEMOConsultationID")
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'CEMO_'+CONVERT([nvarchar](50),NEXT VALUE FOR [dbo].[CEMOConsultationIDSeq],(0)))");

            builder.Property(e => e.AuditReportSigningDate).HasColumnType("datetime");

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.DateCemoreviewRequestedBy)
                .HasColumnName("DateCEMOReviewRequestedBy")
                .HasColumnType("datetime");

            builder.Property(e => e.DiffcultReviewEngtTeamCleared)
                .HasMaxLength(100)
                .IsUnicode(false);

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

            builder.Property(e => e.IsDiscussedWithNaateam)
                .HasColumnName("IsDiscussedWithNAATeam")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.IsRelatedtoMorethanOneEntity).HasDefaultValueSql("((0))");

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
                .WithMany(p => p.Cemoconsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CEMOConsultation_State");

            builder.HasOne(d => d.EpsignoffByNavigation)
                .WithMany(p => p.CemoconsultationEpsignoffByNavigation)
                .HasForeignKey(d => d.EpsignoffBy)
                .HasConstraintName("FK_CEMOConsultation_User");

            builder.HasOne(d => d.NaapartnerSignoffByNavigation)
                .WithMany(p => p.CemoconsultationNaapartnerSignoffByNavigation)
                .HasForeignKey(d => d.NaapartnerSignoffBy)
                .HasConstraintName("FK_CEMOConsultation_User2");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.Cemoconsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CEMOConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.CemoconsultationStateChangedByUser)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CEMOConsultation_User1");
        }
    }
}
