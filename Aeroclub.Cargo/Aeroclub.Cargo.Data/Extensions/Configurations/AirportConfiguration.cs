using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AirportConfiguration : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.Property(p => p.Name).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.Code).HasColumnType("varchar(3)").IsRequired();
        }
    }
}