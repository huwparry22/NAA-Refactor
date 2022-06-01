using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations.Views
{
    public class ViewReviewerSubConfiguration : IEntityTypeConfiguration<ViewReviewerSub>
    {
        public void Configure(EntityTypeBuilder<ViewReviewerSub> builder)
        {
            builder.HasNoKey();

            builder.ToView("View_ReviewerSub");

            builder.Property(e => e.Cm)
                .HasColumnName("CM")
                .HasMaxLength(153);

            builder.Property(e => e.Cmi)
                .HasColumnName("CMI")
                .HasColumnType("datetime");

            builder.Property(e => e.Cmid).HasColumnName("CMID");

            builder.Property(e => e.ConsultationTypeId).HasColumnName("ConsultationTypeID");

            builder.Property(e => e.Ha)
                .HasColumnName("HA")
                .HasMaxLength(153);

            builder.Property(e => e.Hai)
                .HasColumnName("HAI")
                .HasColumnType("datetime");

            builder.Property(e => e.Haid).HasColumnName("HAID");

            builder.Property(e => e.Np)
                .HasColumnName("NP")
                .HasMaxLength(153);

            builder.Property(e => e.Npi)
                .HasColumnName("NPI")
                .HasColumnType("datetime");

            builder.Property(e => e.Npid).HasColumnName("NPID");

            builder.Property(e => e.ReviewBaseId).HasColumnName("ReviewBaseID");
        }
    }
}
