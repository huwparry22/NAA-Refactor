using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewReviewerMainConfiguration : IEntityTypeConfiguration<ViewReviewerMain>
    {
        public void Configure(EntityTypeBuilder<ViewReviewerMain> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ReviewerMain");

            builder.Property(e => e.Em)
                .HasColumnName("EM")
                .HasMaxLength(153);

            builder.Property(e => e.Emid).HasColumnName("EMID");

            builder.Property(e => e.Ep)
                .HasColumnName("EP")
                .HasMaxLength(153);

            builder.Property(e => e.Epid).HasColumnName("EPID");

            builder.Property(e => e.Eq)
                .HasColumnName("EQ")
                .HasMaxLength(153);

            builder.Property(e => e.Eqid).HasColumnName("EQID");

            builder.Property(e => e.Gp)
                .HasColumnName("GP")
                .HasMaxLength(153);

            builder.Property(e => e.Gpid).HasColumnName("GPID");

            builder.Property(e => e.Mc)
                .HasColumnName("MC")
                .HasMaxLength(153);

            builder.Property(e => e.Mcid).HasColumnName("MCID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");
        }
    }
}
