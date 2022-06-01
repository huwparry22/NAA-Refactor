using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class IfrsCategoryConfiguration : IEntityTypeConfiguration<IfrsCategory>
    {
        public void Configure(EntityTypeBuilder<IfrsCategory> builder)
        {
            builder.ToTable("IFRSCategory");

            builder.Property(e => e.IfrscategoryId).HasColumnName("IFRSCategoryID");

            builder.Property(e => e.Category)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.CodeDataId).HasColumnName("CodeDataID");

            builder.Property(e => e.CodeId).HasColumnName("CodeID");

            builder.HasOne(d => d.CodeData)
                .WithMany(p => p.Ifrscategory)
                .HasForeignKey(d => d.CodeDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IFRSCategory_Code_CodeData");
        }
    }
}
