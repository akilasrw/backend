using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class ULDTrackingConfiguration : IEntityTypeConfiguration<ULDTracking>
    {
        public void Configure(EntityTypeBuilder<ULDTracking> builder)
        {
            builder.Property(p => p.LastUsedFlightNumber).HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.LastLocatedAirportCode).HasColumnType("varchar(3)").IsRequired();
        }
    }
}
