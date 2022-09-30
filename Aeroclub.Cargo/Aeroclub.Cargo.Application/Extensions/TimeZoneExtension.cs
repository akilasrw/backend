using NodaTime.TimeZones;

namespace Aeroclub.Cargo.Application.Extensions
{
    public static class TimeZoneExtension
    {
        private enum DistanceUnit { StatuteMile, Kilometer, NauticalMile };
 
        public static DateTime ToInternationalTime(this DateTime UTCtime, string countryCode, double longitude)
        {
            var zones = TzdbDateTimeZoneSource.Default.ZoneLocations.Where(x => x.CountryCode == countryCode.ValidityCountryCode()).AsQueryable();
            if (!double.IsNaN(longitude))
            {
                zones = zones.OrderBy(o => Distance(o.Latitude, longitude, o.Latitude, o.Longitude, DistanceUnit.Kilometer));
            }
            var bestZone = zones.FirstOrDefault();
            var dateTimeZone = TzdbDateTimeZoneSource.Default.ForId(bestZone.ZoneId);

            var newTime = UTCtime.ToConvertToUTC().AddSeconds(dateTimeZone.MaxOffset.Seconds);
            return newTime;

        }

        public static TimeZoneInfo GetBestTimeZoneByCountryId(string countryCode, double longitude)
        {

            var zones = TzdbDateTimeZoneSource.Default.ZoneLocations.Where(x => x.CountryCode == countryCode.ValidityCountryCode()).AsQueryable();
            if (!double.IsNaN(longitude))
            {
                zones = zones.OrderBy(o => Distance(o.Latitude, longitude, o.Latitude, o.Longitude, DistanceUnit.Kilometer));
            }
            var bestZone = zones.FirstOrDefault();
            TimeZoneInfo sysTime = TimeZoneInfo.FindSystemTimeZoneById(bestZone.ZoneId);
            return sysTime;
        }

        public static IEnumerable<TimeZoneInfo> GetTimeZoneByCountryId(string countryCode)
        {
            IEnumerable<string> zoneIds = TzdbDateTimeZoneSource.Default.ZoneLocations
            .Where(x => x.CountryCode == countryCode.ValidityCountryCode())
            .Select(x => x.ZoneId);

            List<TimeZoneInfo> sysTimeList = new List<TimeZoneInfo>();

            foreach (string zoneId in zoneIds) // Eg: Asia/Kuala_Lumpur
            {
                TimeZoneInfo sysTime = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
                sysTimeList.Add(sysTime);
            }
            return sysTimeList; // Eg: (UTC+08:00) Kuala Lumpur, Singapore
        }

        public static DateTime ToConvertToUTC(this DateTime time)
        {
            return TimeZoneInfo.ConvertTimeToUtc(time);
        }

        public static DateTime ToConvertToLocal(this DateTime time)
        {
            return time.ToLocalTime();
        }

        private static double Distance(double lat1, double lon1, double lat2, double lon2, DistanceUnit unit)
        {
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            switch (unit)
            {
                case DistanceUnit.Kilometer:
                    return dist * 1.609344;
                case DistanceUnit.NauticalMile:
                    return dist * 0.8684;
                default:
                case DistanceUnit.StatuteMile: //Miles
                    return dist;
            }
        }

        private static string ValidityCountryCode(this string countryCode)
        {
            if (countryCode.Length > 2)
                return countryCode.Substring(0, 2);
            return countryCode;
        }
    }
}
