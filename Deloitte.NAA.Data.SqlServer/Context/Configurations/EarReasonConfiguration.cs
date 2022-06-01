using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class EarReasonConfiguration : IEntityTypeConfiguration<EarReason>
    {
        public void Configure(EntityTypeBuilder<EarReason> builder)
        {
            builder.HasKey(e => e.EarrequestReasonId);

            builder.ToTable("EARReason");

            builder.Property(e => e.EarrequestReasonId).HasColumnName("EARRequestReasonID");

            builder.Property(e => e.EarrequestReasonDescription)
                .IsRequired()
                .HasColumnName("EARRequestReasonDescription")
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.UpdatedOn).HasColumnType("datetime");
        }
    }
}
