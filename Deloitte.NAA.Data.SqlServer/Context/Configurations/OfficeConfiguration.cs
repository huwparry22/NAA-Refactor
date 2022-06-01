using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(e => e.OfficeId).HasColumnName("OfficeID");

            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.MemberFirmId)
                .HasColumnName("MemberFirmID")
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.SequenceId).HasColumnName("SequenceID");

            builder.HasOne(d => d.MemberFirm)
                .WithMany(p => p.Office)
                .HasForeignKey(d => d.MemberFirmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Office_MemberFirm");
        }
    }
}
