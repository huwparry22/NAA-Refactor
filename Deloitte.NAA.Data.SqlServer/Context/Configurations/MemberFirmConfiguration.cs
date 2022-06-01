using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class MemberFirmConfiguration : IEntityTypeConfiguration<MemberFirm>
    {
        public void Configure(EntityTypeBuilder<MemberFirm> builder)
        {
            //builder.HasIndex(e => e.FirmCode)
            //        .HasName("UQ__MemberFi__ABB637B3CC1BA2DF")
            //        .IsUnique();

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.DisplayFirmCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength();

            builder.Property(e => e.ErrorMessage)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.FirmCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength();

            builder.Property(e => e.FirmName)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
