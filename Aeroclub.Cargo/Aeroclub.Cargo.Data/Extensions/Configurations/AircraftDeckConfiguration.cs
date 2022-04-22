using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AircraftDeckConfiguration : IEntityTypeConfiguration<AircraftDeck>
    {
        public void Configure(EntityTypeBuilder<AircraftDeck> builder)
        {
            builder.Property(p => p.AircraftDeckType).HasColumnType("smallint").IsRequired();
        }
    }
}