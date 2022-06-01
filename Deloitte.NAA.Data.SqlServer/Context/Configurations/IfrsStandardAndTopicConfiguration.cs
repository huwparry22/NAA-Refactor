using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class IfrsStandardAndTopicConfiguration : IEntityTypeConfiguration<IfrsStandardAndTopic>
    {
        public void Configure(EntityTypeBuilder<IfrsStandardAndTopic> builder)
        {
            builder.ToTable("IFRSStandardAndTopic");

            builder.Property(e => e.IfrsstandardAndTopicId).HasColumnName("IFRSStandardAndTopicID");

            builder.Property(e => e.AccountingConsultationId)
                .IsRequired()
                .HasColumnName("AccountingConsultationID")
                .HasMaxLength(50);

            builder.Property(e => e.IfrscategoryId).HasColumnName("IFRSCategoryID");

            builder.Property(e => e.IfrssubCategoryId).HasColumnName("IFRSSubCategoryID");

            builder.HasOne(d => d.AccountingConsultation)
                .WithMany(p => p.IfrsstandardAndTopic)
                .HasForeignKey(d => d.AccountingConsultationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IFRSStandardAndTopic_AccountingConsultationID");

            builder.HasOne(d => d.Ifrscategory)
                .WithMany(p => p.IfrsstandardAndTopic)
                .HasForeignKey(d => d.IfrscategoryId)
                .HasConstraintName("FK_IFRSStandardAndTopic_IFRSCategoryID");

            builder.HasOne(d => d.IfrssubCategory)
                .WithMany(p => p.IfrsstandardAndTopic)
                .HasForeignKey(d => d.IfrssubCategoryId)
                .HasConstraintName("FK_IFRSStandardAndTopic_IFRSSubCategoryID");
        }
    }
}
