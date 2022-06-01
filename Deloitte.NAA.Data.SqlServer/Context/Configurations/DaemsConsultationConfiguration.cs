using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class DaemsConsultationConfiguration : IEntityTypeConfiguration<DaemsConsultation>
    {
        public void Configure(EntityTypeBuilder<DaemsConsultation> builder)
        {
            builder.ToTable("DAEMSConsultation");

            builder.Property(e => e.DaemsconsultationId)
                .HasColumnName("DAEMSConsultationID")
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'DAEMS_'+CONVERT([nvarchar](50),NEXT VALUE FOR [dbo].[DAEMSConsultationIDSeq],(0)))");

            builder.Property(e => e.ArchiveDeadlineDate).HasColumnType("datetime");

            builder.Property(e => e.AuditStandardId).HasColumnName("AuditStandardID");

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.DocumentOtherInformation)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.EmsfileName)
                .HasColumnName("EMSFileName")
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.EmsversionId).HasColumnName("EMSVersionID");

            builder.Property(e => e.EngagementTypeId).HasColumnName("EngagementTypeID");

            builder.Property(e => e.EpsignoffBy).HasColumnName("EPSignoffBy");

            builder.Property(e => e.EpsignoffDateTime)
                .HasColumnName("EPSignoffDateTime")
                .HasColumnType("datetime");

            builder.Property(e => e.FactsAndCircumstancesOfQuery).HasMaxLength(4000);

            builder.Property(e => e.FileId)
                .HasColumnName("FileID")
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.IsDiscussedWithNaateam)
                .HasColumnName("IsDiscussedWithNAATeam")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.IsRelatedtoMorethanOneEntity).HasDefaultValueSql("((0))");

            builder.Property(e => e.ItscallId)
                .HasColumnName("ITSCallID")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.LetterBoxAuditId).HasColumnName("LetterBoxAuditID");

            builder.Property(e => e.LetterBoxAuditSpecify)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.LocalMemberFirmPerformsFieldWorkId).HasColumnName("LocalMemberFirmPerformsFieldWorkID");

            builder.Property(e => e.MemberFirmEngagementFile)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.MemberFirmPerformsFieldWorkId).HasColumnName("MemberFirmPerformsFieldWorkID");

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

            builder.Property(e => e.ReasonForRequest)
                .HasMaxLength(4000)
                .IsUnicode(false);

            builder.Property(e => e.ReasonForRequestId).HasColumnName("ReasonForRequestID");

            builder.Property(e => e.RejectionReason).HasMaxLength(2000);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.StateChangedByUserId).HasColumnName("StateChangedByUserID");

            builder.Property(e => e.StateChangedDate).HasColumnType("datetime");

            builder.Property(e => e.TypeOfConsultationId).HasColumnName("TypeOfConsultationID");

            builder.Property(e => e.WithdrawalApprovalReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.WithdrawalReason).HasMaxLength(2000);

            builder.HasOne(d => d.CurrentState)
                .WithMany(p => p.Daemsconsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAEMSConsultation_State");

            builder.HasOne(d => d.EpsignoffByNavigation)
                .WithMany(p => p.DaemsconsultationEpsignoffByNavigation)
                .HasForeignKey(d => d.EpsignoffBy)
                .HasConstraintName("FK_DAEMSConsultation_User");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.Daemsconsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAEMSConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.DaemsconsultationStateChangedByUser)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DAEMSConsultation_User1");
        }
    }
}
