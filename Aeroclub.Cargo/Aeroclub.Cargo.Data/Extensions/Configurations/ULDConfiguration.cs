using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class ULDConfiguration : IEntityTypeConfiguration<ULD>
    {
        public void Configure(EntityTypeBuilder<ULD> builder)
        {
            builder.Property(p => p.SerialNumber).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.LendAirlineCode).HasColumnType("varchar(2)").IsRequired();
            builder.Property(p => p.OwnerAirlineCode).HasColumnType("varchar(2)").IsRequired();
            builder.Property(p => p.ULDType).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.ULDOwnershipType).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.ULDLocateStatus).HasColumnType("tinyint").IsRequired();


        }
    }
}