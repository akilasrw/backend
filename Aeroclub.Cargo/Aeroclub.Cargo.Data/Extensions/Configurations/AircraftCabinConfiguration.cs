using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AircraftCabinConfiguration : IEntityTypeConfiguration<AircraftCabin>
    {
        public void Configure(EntityTypeBuilder<AircraftCabin> builder)
        {
            builder.Property(p => p.Name).HasColumnType("varchar(100)").IsRequired();
        }
    }
}