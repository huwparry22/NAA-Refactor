using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class ReviewBaseConfiguration : IEntityTypeConfiguration<ReviewBase>
    {
        public void Configure(EntityTypeBuilder<ReviewBase> builder)
        {
            //builder.HasIndex(e => new { e.ReviewBaseId, e.EntityName, e.StateChangedDate, e.IsConfidentialQuery, e.CurrentStateId })
            //        .HasName("IDX_ReviewBase:Composite22965");

            builder.Property(e => e.ReviewBaseId)
                .HasColumnName("ReviewBaseID")
                .ValueGeneratedNever();

            builder.Property(e => e.AmountBilled).HasColumnType("decimal(10, 2)");

            builder.Property(e => e.ArmentityId)
                .HasColumnName("ARMEntityID")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.CalculatedCharge).HasColumnType("decimal(10, 2)");

            builder.Property(e => e.CurrentStateId).HasColumnName("CurrentStateID");

            builder.Property(e => e.DateBilled).HasColumnType("datetime");

            builder.Property(e => e.Dunsnumber)
                .HasColumnName("DUNSNumber")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.EntityName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.FinancialYearEnd).HasColumnType("datetime");

            builder.Property(e => e.IsRelatedToSecregistrant).HasColumnName("IsRelatedToSECRegistrant");

            builder.Property(e => e.IsSecregistrant).HasColumnName("IsSECRegistrant");

            builder.Property(e => e.IsSecrelationship).HasColumnName("IsSECRelationship");

            builder.Property(e => e.MarketListings)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.MemberFirmId).HasColumnName("MemberFirmID");

            builder.Property(e => e.OperatingUnit)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PartnerOfficeId).HasColumnName("PartnerOfficeID");

            builder.Property(e => e.RiskRatingReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.StateChangedByUserId).HasColumnName("StateChangedByUserID");

            builder.Property(e => e.StateChangedDate).HasColumnType("datetime");

            builder.Property(e => e.Uhcdunsnumber)
                .HasColumnName("UHCDUNSNumber")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Uhcname)
                .HasColumnName("UHCName")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Wbsnumber)
                .HasColumnName("WBSNumber")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.WithdrawalApprovalReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.WithdrawalReason)
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.HasOne(d => d.CurrentState)
                .WithMany(p => p.ReviewBase)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewBase_State");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.ReviewBase)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewBase_MemberFirm");

            builder.HasOne(d => d.PartnerOffice)
                .WithMany(p => p.ReviewBase)
                .HasForeignKey(d => d.PartnerOfficeId)
                .HasConstraintName("FK_ReviewBase_Office");

            builder.HasOne(d => d.StateChangedByUser)
                .WithMany(p => p.ReviewBase)
                .HasForeignKey(d => d.StateChangedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReviewBase_User1");
        }
    }
}
