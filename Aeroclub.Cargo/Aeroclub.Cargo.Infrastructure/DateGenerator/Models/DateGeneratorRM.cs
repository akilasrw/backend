
namespace Aeroclub.Cargo.Infrastructure.DateGenerator.Models
{
    public class DateGeneratorRM
    {
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public string DaysOfWeek { get; set; } = null!;
    }
}
