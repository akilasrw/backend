using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class CargoPositionConfiguration : IEntityTypeConfiguration<CargoPosition>
    {
        public void Configure(EntityTypeBuilder<CargoPosition> builder)
        {
            builder.Property(p => p.Name).HasColumnType("varchar(40)").IsRequired();
        }
    }
}