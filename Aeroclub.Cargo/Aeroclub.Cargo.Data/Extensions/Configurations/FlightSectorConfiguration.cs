using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class FlightSectorConfiguration : IEntityTypeConfiguration<FlightSector>
    {
        public void Configure(EntityTypeBuilder<FlightSector> builder)
        {
            builder.HasKey(x => new { x.FlightId, x.SectorId });
            builder.Property(p => p.Sequence).HasColumnType("tinyint");
            
            builder
                .HasOne(x => x.Flight)
                .WithMany(y => y.FlightSectors)
                .HasForeignKey(x => x.FlightId);
            builder
                .HasOne(x => x.Sector)
                .WithMany(y => y.FlightSectors)
                .HasForeignKey(x => x.SectorId);
        }
    }
}