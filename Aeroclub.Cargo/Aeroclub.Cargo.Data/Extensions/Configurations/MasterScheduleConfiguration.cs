using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class MasterScheduleConfiguration : IEntityTypeConfiguration<MasterSchedule>
    {
        public void Configure(EntityTypeBuilder<MasterSchedule> builder)
        {
            builder.Property(p => p.DaysOfWeek).HasColumnType("varchar(20)");
            builder.Property(p => p.CalendarType).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.ScheduleStatus).HasColumnType("tinyint").IsRequired();
        }
    }
}
