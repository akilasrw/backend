using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class FlightScheduleSectorConfiguration : IEntityTypeConfiguration<FlightScheduleSector>
    {
        public void Configure(EntityTypeBuilder<FlightScheduleSector> builder)
        {
            builder.Property(p => p.FlightNumber).HasColumnType("varchar(10)");
            builder.Property(p => p.OriginAirportCode).HasColumnType("varchar(3)").IsRequired();
            builder.Property(p => p.DestinationAirportCode).HasColumnType("varchar(3)").IsRequired();
            builder.Property(p => p.OriginAirportName).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.DestinationAirportName).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.FlightScheduleStatus).HasColumnType("tinyint").IsRequired();

            builder.HasMany(ur => ur.CargoBookings)
               .WithOne(u => u.FlightScheduleSector)
               .HasForeignKey(ur => ur.FlightScheduleSectorId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}