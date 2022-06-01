using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class SubsidiaryEntityConfiguration : IEntityTypeConfiguration<SubsidiaryEntity>
    {
        public void Configure(EntityTypeBuilder<SubsidiaryEntity> builder)
        {
            builder.HasIndex(e => e.EngagementManagerId);

            builder.HasIndex(e => e.EngagementPartnerId);

            builder.HasIndex(e => e.ReviewBaseId);

            builder.Property(e => e.ArmEntityId)
                .IsRequired()
                .HasColumnName("ArmEntityID")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.EngagementManagerId).HasColumnName("EngagementManagerID");

            builder.Property(e => e.EngagementPartnerId).HasColumnName("EngagementPartnerID");

            builder.Property(e => e.EntityName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");

            builder.Property(e => e.RowTimestamp)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            builder.Property(e => e.Uhcdunsnumber)
                .HasColumnName("UHCDUNSNumber")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.EngagementManager)
                .WithMany(p => p.SubsidiaryEntityEngagementManager)
                .HasForeignKey(d => d.EngagementManagerId)
                .HasConstraintName("FK_SubsidiaryEntity_User");

            builder.HasOne(d => d.EngagementPartner)
                .WithMany(p => p.SubsidiaryEntityEngagementPartner)
                .HasForeignKey(d => d.EngagementPartnerId)
                .HasConstraintName("FK_SubsidiaryEntity_Userpartner");

            builder.HasOne(d => d.ReviewBase)
                .WithMany(p => p.SubsidiaryEntity)
                .HasForeignKey(d => d.ReviewBaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubsidiaryEntity_FileReview");
        }
    }
}
