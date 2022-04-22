using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class SeatEntityConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.Property(p => p.RowNumber).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.ColumnNumber).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.SeatNumber).HasColumnType("varchar(10)").IsRequired();
        }
    }
}