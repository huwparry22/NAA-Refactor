using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CgovConsultationConfiguration : IEntityTypeConfiguration<CgovConsultation>
    {
        public void Configure(EntityTypeBuilder<CgovConsultation> builder)
        {
            builder.ToTable("CGovConsultation");

            //builder.HasIndex(e => e.ReviewBaseId)
            //    .HasName("IDX_CGovConsultation:Composite5420");

            builder.Property(e => e.CgovConsultationId)
                .HasColumnName("CGovConsultationID")
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'CorporateGOV_'+CONVERT([nvarchar](50),NEXT VALUE FOR [dbo].[CGovConsultationIDSeq],(0)))");

            builder.Property(e => e.BasisoftheConsultationResponse).HasMaxLength(2000);

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.Conditions).HasMaxLength(2000);

            builder.Property(e => e.ConsultationResponse).HasMaxLength(2000);

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.DesiredTimingOfCompletion).HasColumnType("datetime");

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

            builder.Property(e => e.KeyMileStoneDate).HasColumnType("datetime");

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

            builder.Property(e => e.PlannedSubmissionDate).HasColumnType("datetime");

            builder.Property(e => e.PreSignOffDateTime).HasColumnType("datetime");

            builder.Property(e => e.PriorityId).HasColumnName("PriorityID");

            builder.Property(e => e.PriorityReason).HasMaxLength(200);

            builder.Property(e => e.QueryDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.QueryRelateToFtse350entity).HasColumnName("QueryRelateToFTSE350Entity");

            builder.Property(e => e.References).HasMaxLength(2000);

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
                .WithMany(p => p.CgovConsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CGovConsultation_State");

            builder.HasOne(d => d.EpsignoffByNavigation)
                .WithMany(p => p.CgovConsultationEpsignoffByNavigation)
                .HasForeignKey(d => d.EpsignoffBy)
                .HasConstraintName("FK_CGovConsultation_User");

            builder.HasOne(d => d.EqcrsignoffByNavigation)
                .WithMany(p => p.CgovConsultationEqcrsignoffByNavigation)
                .HasForeignKey(d => d.EqcrsignoffBy)
                .HasConstraintName("FK_CGovConsultation_User3");

            builder.HasOne(d => d.NaapartnerSignoffByNavigation)
                .WithMany(p => p.CgovConsultationNaapartnerSignoffByNavigation)
                .HasForeignKey(d => d.NaapartnerSignoffBy)
                .HasConstraintName("FK_CGovConsultation_User2");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.CgovConsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CGovConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.CgovConsultationStateChangedByUser)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CGovConsultation_User1");
        }
    }
}
