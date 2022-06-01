using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewStateConfiguration : IEntityTypeConfiguration<ReviewState>
    {
        public void Configure(EntityTypeBuilder<ReviewState> builder)
        {
            //builder.HasIndex(e => e.ConsultationTypeId)
            //        .HasName("index_Perform");

            builder.HasIndex(e => e.OperationId);

            builder.HasIndex(e => e.ReviewBaseId);

            builder.HasIndex(e => e.StateChangeSetByUserId);

            builder.HasIndex(e => e.StateChangeTime);

            builder.HasIndex(e => e.StateId);

            //builder.HasIndex(e => new { e.ReviewBaseId, e.StateChangeTime, e.StateId, e.OperationId, e.ConsultationTypeId })
            //    .HasName("IDX_ReviewState:Composite107673");

            builder.Property(e => e.ReviewStateId).HasColumnName("ReviewStateID");

            builder.Property(e => e.AdditionalText).HasMaxLength(1000);

            builder.Property(e => e.ConsultationTypeId)
                .IsRequired()
                .HasColumnName("ConsultationTypeID")
                .HasMaxLength(50);

            builder.Property(e => e.OperationId).HasColumnName("OperationID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.StateChangeSetByUserId).HasColumnName("StateChangeSetByUserID");

            builder.Property(e => e.StateChangeTime)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.StateId).HasColumnName("StateID");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.ReviewState)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewState_ReviewBase");

            builder.HasOne(d => d.StateChangeSetByUser)
                .WithMany(p => p.ReviewState)
                .HasForeignKey(d => d.StateChangeSetByUserId)
                .HasConstraintName("FK_ReviewState_User");

            builder.HasOne(d => d.State)
                .WithMany(p => p.ReviewState)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewState_State1");
        }
    }
}
