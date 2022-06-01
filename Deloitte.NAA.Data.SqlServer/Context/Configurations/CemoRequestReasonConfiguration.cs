using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class CemoRequestReasonConfiguration : IEntityTypeConfiguration<CemoRequestReason>
    {
        public void Configure(EntityTypeBuilder<CemoRequestReason> builder)
        {
            builder.ToTable("CEMORequestReason");

            builder.Property(e => e.CemorequestReasonId).HasColumnName("CEMORequestReasonID");

            builder.Property(e => e.CemorequestReasonDescription)
                .IsRequired()
                .HasColumnName("CEMORequestReasonDescription")
                .HasMaxLength(2000)
                .IsUnicode(false);

            builder.Property(e => e.UpdatedOn).HasColumnType("datetime");
        }
    }
}
