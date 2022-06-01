using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PsrArmUpdatesConfiguration : IEntityTypeConfiguration<PsrArmUpdates>
    {
        public void Configure(EntityTypeBuilder<PsrArmUpdates> builder)
        {
            builder.HasKey(e => e.UniqueIdentifier)
                    .HasName("UniqueIdentifier");

            builder.ToTable("PSRARMUpdates");

            builder.Property(e => e.UniqueIdentifier).ValueGeneratedNever();

            builder.Property(e => e.ArmentityId)
                .IsRequired()
                .HasColumnName("ARMEntityID")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.CurrentState)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.DocumentReviewType)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.DocumentReviewTypeCategory)
                .IsRequired()
                .HasMaxLength(700)
                .IsUnicode(false);

            builder.Property(e => e.FinancialYearEnd).HasColumnType("datetime");

            builder.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

            builder.Property(e => e.PreferredReviewDate).HasColumnType("datetime");

            builder.Property(e => e.ProcessedInArm)
                .HasColumnName("ProcessedInARM")
                .HasColumnType("datetime");

            builder.Property(e => e.PsrlogNo).HasColumnName("PSRLogNo");

            builder.Property(e => e.ReasonForFailure)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.SentToArm)
                .HasColumnName("SentToARM")
                .HasColumnType("datetime");

            builder.Property(e => e.StateChangedDateTime).HasColumnType("datetime");

            builder.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        }
    }
}
