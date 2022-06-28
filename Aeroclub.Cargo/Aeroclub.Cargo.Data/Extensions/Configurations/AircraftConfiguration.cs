using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.Property(p => p.RegNo).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.AircraftType).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.AircraftSubType).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.ConfigurationType).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.Status).HasColumnType("smallint").IsRequired();
        }
    }
}