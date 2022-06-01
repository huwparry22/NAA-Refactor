using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class AccountingConsultationConfiguration : IEntityTypeConfiguration<AccountingConsultation>
    {
        public void Configure(EntityTypeBuilder<AccountingConsultation> builder)
        {
            //builder.HasIndex(e => e.ReviewBaseId)
            //        .HasName("IDX_AccountingConsultation:Composite5414");

            //builder.HasIndex(e => new { e.ReviewBaseId, e.CurrentStateId })
            //        .HasName("IDX_AccountingConsultation:Composite13315");

            //builder.HasIndex(e => new { e.ReviewBaseId, e.PriorityId })
            //    .HasName("IDX_AccountingConsultation:Composite13339");

            //builder.HasIndex(e => new { e.AccountingConsultationId, e.QueryDescription, e.CurrentStateId, e.StateChangedDate, e.Notes, e.ReviewBaseId, e.PriorityId })
            //    .HasName("IDX_AccountingConsultation:Composite30044");

            //builder.HasIndex(e => new { e.AccountingConsultationId, e.ReviewBaseId, e.QueryDescription, e.CurrentStateId, e.StateChangedDate, e.Notes, e.PriorityId })
            //    .HasName("IDX_AccountingConsultation:Composite30046");

            //builder.HasIndex(e => new { e.AccountingConsultationId, e.ReviewBaseId, e.QueryDescription, e.StateChangedDate, e.PriorityId, e.Notes, e.CurrentStateId })
            //    .HasName("IDX_AccountingConsultation:Composite13355");

            //builder.HasIndex(e => new { e.AccountingConsultationId, e.FactsAndCircumstancesOfQuery, e.EpsignoffBy, e.EpsignoffDateTime, e.BasisoftheConsultationResponse, e.ConsultationResponse, e.Conditions, e.HasaFormalResponseBeenRequested, e.IsRelatedtoMorethanOneEntity, e.ReviewBaseId, e.CurrentStateId })
            //    .HasName("IDX_AccountingConsultation:Composite13353");

            //builder.HasIndex(e => new { e.AccountingConsultationId, e.QueryDescription, e.RequestTypeId, e.FactsAndCircumstancesOfQuery, e.EpsignoffBy, e.EpsignoffDateTime, e.BasisoftheConsultationResponse, e.ConsultationResponse, e.Conditions, e.References, e.OtherRemarks, e.HasaFormalResponseBeenRequested, e.IsRelatedtoMorethanOneEntity, e.NumberofEntities, e.NameofEntities, e.ReviewBaseId })
            //    .HasName("IDX_AccountingConsultation:Composite23898");

            builder.Property(e => e.AccountingConsultationId)
                .HasColumnName("AccountingConsultationID")
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Accounting_'+CONVERT([nvarchar](50),NEXT VALUE FOR [dbo].[AccountingConsultationIDSeq],(0)))");

            builder.Property(e => e.AccountingStandardRefrence).HasMaxLength(4000);

            builder.Property(e => e.BasisoftheConsultationResponse).HasMaxLength(2000);

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.CommentstoImproveGuidance).HasMaxLength(4000);

            builder.Property(e => e.ConclusionPriorYearId).HasColumnName("ConclusionPriorYearID");

            builder.Property(e => e.Conditions).HasMaxLength(2000);

            builder.Property(e => e.ConsultationResponse).HasMaxLength(2000);

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.EpsignoffBy).HasColumnName("EPSignoffBy");

            builder.Property(e => e.EpsignoffDateTime)
                .HasColumnName("EPSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.EqcrsignoffBy).HasColumnName("EQCRSignoffBy");

            builder.Property(e => e.EqcrsignoffDateTime)
                .HasColumnName("EQCRSignoffDateTime")
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

            builder.Property(e => e.OtherRemarks).HasMaxLength(2000);

            builder.Property(e => e.PreSignOffDateTime).HasColumnType("datetime");

            builder.Property(e => e.PriorYearEntityId).HasColumnName("PriorYearEntityID");

            builder.Property(e => e.PriorityId).HasColumnName("PriorityID");

            builder.Property(e => e.PriorityReason).HasMaxLength(200);

            builder.Property(e => e.QueryDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.References).HasMaxLength(2000);

            builder.Property(e => e.RefrenceGuidance).HasMaxLength(500);

            builder.Property(e => e.RejectionReason).HasMaxLength(2000);

            builder.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

            builder.Property(e => e.ResearchUndertaken)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.StateChangedByUserId).HasColumnName("StateChangedByUserID");

            builder.Property(e => e.StateChangedDate).HasColumnType("datetime");

            builder.Property(e => e.TypeofChangeinAccountingId).HasColumnName("TypeofChangeinAccountingID");

            builder.Property(e => e.WithdrawalApprovalReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.WithdrawalReason).HasMaxLength(2000);

            builder.HasOne(d => d.CurrentState)
                .WithMany(p => p.AccountingConsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountingConsultation_State");

            builder.HasOne(d => d.EpsignoffByNavigation)
                .WithMany(p => p.AccountingConsultationEpsignoffByNavigation)
                .HasForeignKey(d => d.EpsignoffBy)
                .HasConstraintName("FK_AccountingConsultation_User");

            builder.HasOne(d => d.EqcrsignoffByNavigation)
                .WithMany(p => p.AccountingConsultationEqcrsignoffByNavigation)
                .HasForeignKey(d => d.EqcrsignoffBy)
                .HasConstraintName("FK_AccountingConsultation_User3");

            builder.HasOne(d => d.NaapartnerSignoffByNavigation)
                .WithMany(p => p.AccountingConsultationNaapartnerSignoffByNavigation)
                .HasForeignKey(d => d.NaapartnerSignoffBy)
                .HasConstraintName("FK_AccountingConsultation_User2");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.AccountingConsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountingConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.AccountingConsultationStateChangedByUser)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountingConsultation_User1");
        }
    }
}
