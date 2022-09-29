using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class FlightScheduleManagementConfiguration : IEntityTypeConfiguration<FlightScheduleManagement>
    {
        public void Configure(EntityTypeBuilder<FlightScheduleManagement> builder)
        {
            builder.Property(p => p.DaysOfWeek).HasColumnType("varchar(20)").IsRequired();

        }
    }
}
