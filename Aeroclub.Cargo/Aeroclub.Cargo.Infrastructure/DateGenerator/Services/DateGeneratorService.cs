using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Interfaces;
using Aeroclub.Cargo.Infrastructure.DateGenerator.Models;

namespace Aeroclub.Cargo.Infrastructure.DateGenerator.Services
{
    public class DateGeneratorService : IDateGeneratorService
    {
        public DateGeneratorService()
        {

        }

        public List<DateTime> GetDates(DateGeneratorRM dto)
        {
            IList<int> daysOfWeek = new List<int>();
            List<DateTime> bookingDays = new List<DateTime>();

            if (!String.IsNullOrEmpty(dto.DaysOfWeek))
            {
                foreach (var s in dto.DaysOfWeek.Split(','))
                {
                    int num;
                    if (int.TryParse(s, out num))
                        daysOfWeek.Add(num);
                }
            }

            if (daysOfWeek.Count > 0)
            {
                foreach (var day in daysOfWeek)
                {
                    bookingDays.AddRange(dto.ScheduleStartDate.GetWeekdayInRange(dto.ScheduleEndDate, day.GetDayOfWeek()));
                }
            }

            return bookingDays;
        }
    }
}
