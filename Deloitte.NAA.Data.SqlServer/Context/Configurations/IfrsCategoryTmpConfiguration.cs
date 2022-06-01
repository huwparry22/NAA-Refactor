using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class IfrsCategoryTmpConfiguration : IEntityTypeConfiguration<IfrsCategoryTmp>
    {
        public void Configure(EntityTypeBuilder<IfrsCategoryTmp> builder)
        {
            builder.HasKey(e => e.IfrscategoryId);

            builder.ToTable("IFRSCategoryTmp");

            builder.Property(e => e.IfrscategoryId).HasColumnName("IFRSCategoryID");

            builder.Property(e => e.Category)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.CodeDataId).HasColumnName("CodeDataID");

            builder.Property(e => e.CodeId).HasColumnName("CodeID");
        }
    }
}
