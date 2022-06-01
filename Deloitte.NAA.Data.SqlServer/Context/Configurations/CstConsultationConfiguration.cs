using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CstConsultationConfiguration : IEntityTypeConfiguration<CstConsultation>
    {
        public void Configure(EntityTypeBuilder<CstConsultation> builder)
        {
            builder.ToTable("CSTConsultation");

            builder.Property(e => e.CstconsultationId)
                .HasColumnName("CSTConsultationID")
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'CST_'+CONVERT([nvarchar](50),NEXT VALUE FOR [dbo].[CSTConsultationIDSeq],(0)))");

            builder.Property(e => e.ChaserEmailUpdateDate).HasColumnType("datetime");

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.FactsAndCircumstancesOfQuery).HasMaxLength(4000);

            builder.Property(e => e.FollowUpRequiredDate).HasColumnType("datetime");

            builder.Property(e => e.IsDiscussedWithNaateam)
                .HasColumnName("IsDiscussedWithNAATeam")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.IsRelatedtoMorethanOneEntity).HasDefaultValueSql("((0))");

            builder.Property(e => e.LocationOfDataFile)
                .HasMaxLength(1000)
                .IsUnicode(false);

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

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.StateChangedByUserId).HasColumnName("StateChangedByUserID");

            builder.Property(e => e.StateChangedDate).HasColumnType("datetime");

            builder.Property(e => e.SubjectMatterId).HasColumnName("SubjectMatterID");

            builder.Property(e => e.WithdrawalApprovalReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.WithdrawalReason).HasMaxLength(2000);

            builder.HasOne(d => d.CurrentState)
                .WithMany(p => p.Cstconsultation)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CSTConsultation_State");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.Cstconsultation)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CSTConsultation_ReviewBase");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.Cstconsultation)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CSTConsultation_User");
        }
    }
}
