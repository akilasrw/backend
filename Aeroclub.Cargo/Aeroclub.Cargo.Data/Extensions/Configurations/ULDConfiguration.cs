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
        }
    }
}