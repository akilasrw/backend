using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class SectorConfiguration : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.Property(p => p.OriginAirportCode).HasColumnType("varchar(3)").IsRequired();
            builder.Property(p => p.DestinationAirportCode).HasColumnType("varchar(3)").IsRequired();
            builder.Property(p => p.OriginAirportName).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.DestinationAirportName).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.SectorType).HasColumnType("tinyint").IsRequired();
        }
    }
}