using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class IfrsSubCategoryTmpConfiguration : IEntityTypeConfiguration<IfrsSubCategoryTmp>
    {
        public void Configure(EntityTypeBuilder<IfrsSubCategoryTmp> builder)
        {
            builder.HasKey(e => e.IfrssubCategoryId);

            builder.ToTable("IFRSSubCategoryTmp");

            builder.Property(e => e.IfrssubCategoryId).HasColumnName("IFRSSubCategoryID");

            builder.Property(e => e.IfrscategoryId).HasColumnName("IFRSCategoryID");

            builder.Property(e => e.SubCategory)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(d => d.Ifrscategory)
                .WithMany(p => p.IfrssubCategoryTmp)
                .HasForeignKey(d => d.IfrscategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IFRSSubCategoryTmp_IFRSCategoryTmp");
        }
    }
}
