using Deloitte.NAA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deloitte.NAA.Data.SqlServer.Context.Configurations
{
    public class PsrArmUpdateSsisJobProgressConfiguration : IEntityTypeConfiguration<PsrArmUpdateSsisJobProgress>
    {
        public void Configure(EntityTypeBuilder<PsrArmUpdateSsisJobProgress> builder)
        {
            builder.HasNoKey();

            builder.ToTable("PSRARMUpdateSSISJobProgress");

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.PsrarmupdatesTableUpdatedOn)
                .HasColumnName("PSRARMUpdatesTableUpdatedOn")
                .HasColumnType("datetime");
        }
    }
}
