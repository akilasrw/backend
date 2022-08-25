using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class CargoBookingConfiguration : IEntityTypeConfiguration<CargoBooking>
    {
        public void Configure(EntityTypeBuilder<CargoBooking> builder)
        {
            builder.Property(p => p.BookingNumber).HasColumnType("varchar(40)").IsRequired();
            builder.Property(p => p.BookingStatus).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.AWBStatus).HasColumnType("tinyint").IsRequired();
            builder.HasQueryFilter(p => !EF.Property<bool>(p, "IsDeleted"));

        }
    }
}