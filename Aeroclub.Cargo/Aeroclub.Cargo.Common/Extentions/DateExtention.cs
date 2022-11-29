
namespace Aeroclub.Cargo.Common.Extentions
{
    public static class DateExtention
    {
        public static List<DateTime> GetWeekdayInRange(this DateTime from, DateTime to, DayOfWeek day)
        {
            const int daysInWeek = 7;
            var result = new List<DateTime>();
            var daysToAdd = ((int)day - (int)from.DayOfWeek + daysInWeek) % daysInWeek;

            do
            {
                from = from.AddDays(daysToAdd);
                if (from <= to)
                    result.Add(from);
                
                daysToAdd = daysInWeek;
            } while (from < to);

            return result;
        }

        public static DayOfWeek GetDayOfWeek(this int dateNumber)
        {
            switch (dateNumber)
            {
                case 1:
                    return DayOfWeek.Monday;
                case 2:
                    return DayOfWeek.Tuesday;
                case 3:
                    return DayOfWeek.Wednesday;
                case 4:
                    return DayOfWeek.Thursday;
                case 5:
                    return DayOfWeek.Friday;
                case 6:
                    return DayOfWeek.Saturday;
                case 7:
                    return DayOfWeek.Sunday;
                default:
                    return DayOfWeek.Monday;
            }
        }

        public static IEnumerable<DateTime> AllDatesInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(year, month, day);
            }
        }
    }
}
