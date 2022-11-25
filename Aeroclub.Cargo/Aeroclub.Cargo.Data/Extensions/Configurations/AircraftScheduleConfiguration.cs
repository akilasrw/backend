using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AircraftScheduleConfiguration : IEntityTypeConfiguration<AircraftSchedule>
    {
        public void Configure(EntityTypeBuilder<AircraftSchedule> builder)
        {
            builder.Property(p => p.ScheduleStatus).HasColumnType("tinyint").IsRequired();

        }

    }
}
