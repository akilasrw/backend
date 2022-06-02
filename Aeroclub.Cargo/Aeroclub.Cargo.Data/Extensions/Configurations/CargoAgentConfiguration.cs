using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class CargoAgentConfiguration : IEntityTypeConfiguration<CargoAgent>
    {
        public void Configure(EntityTypeBuilder<CargoAgent> builder)
        {
            builder.Property(p => p.AgentName).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.Address).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(p => p.PrimaryTelephoneNumber).HasColumnType("varchar(12)").IsRequired();
            builder.Property(p => p.SecondaryTelephoneNumber).HasColumnType("varchar(12)");
            builder.Property(p => p.CargoAccountNumber).HasColumnType("varchar(20)");
            builder.Property(p => p.City).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(p => p.AgentIATACode).HasColumnType("varchar(20)");
        }
    }
}
