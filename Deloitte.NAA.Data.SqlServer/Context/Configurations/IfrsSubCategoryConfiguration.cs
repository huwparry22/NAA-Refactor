using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class IfrsSubCategoryConfiguration : IEntityTypeConfiguration<IfrsSubCategory>
    {
        public void Configure(EntityTypeBuilder<IfrsSubCategory> builder)
        {
            builder.ToTable("IFRSSubCategory");

            builder.Property(e => e.IfrssubCategoryId).HasColumnName("IFRSSubCategoryID");

            builder.Property(e => e.IfrscategoryId).HasColumnName("IFRSCategoryID");

            builder.Property(e => e.SubCategory)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasOne(d => d.Ifrscategory)
                .WithMany(p => p.IfrssubCategory)
                .HasForeignKey(d => d.IfrscategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IFRSSubCategory_IFRSCategory");
        }
    }
}
