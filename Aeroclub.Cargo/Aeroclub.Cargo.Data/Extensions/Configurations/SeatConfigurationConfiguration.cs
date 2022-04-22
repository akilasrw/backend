using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class SeatConfigurationConfiguration : IEntityTypeConfiguration<SeatConfiguration>
    {
        public void Configure(EntityTypeBuilder<SeatConfiguration> builder)
        {
            builder.Property(p => p.RowNumber).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.ColumnNumber).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.SeatConfigurationType).HasColumnType("tinyint").IsRequired();
        }
    }
}