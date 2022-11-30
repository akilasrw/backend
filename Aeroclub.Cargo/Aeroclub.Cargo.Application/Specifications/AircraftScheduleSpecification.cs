using Aeroclub.Cargo.Application.Models.Queries.AircraftScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class AircraftScheduleSpecification : BaseSpecification<AircraftSchedule>
    {
        public AircraftScheduleSpecification(AircraftScheduleQM query)
            : base(x => x.AircraftId == query.AircraftId && x.IsCompleted == query.IsScheduleCompleted && !x.IsDeleted)
        {
                
        }

        public AircraftScheduleSpecification(AircraftScheduleListQM query)
            : base(x=> x.ScheduleStartDateTime.Date == query.ScheduleStartDate.Date || (query.ScheduleStartDate.Date > x.ScheduleStartDateTime.Date && query.ScheduleStartDate.Date <= x.ScheduleEndDateTime.Date))
        {
            AddInclude(x => x.Include(y => y.MasterSchedule));

            if (query.IsIncludeAircraft)
                AddInclude(x => x.Include(y => y.Aircraft));

            if (query.IsIncludeFlightSchedules)
                AddInclude(x => x.Include(y => y.FlightSchedules).ThenInclude(a=>a.FlightScheduleSectors).ThenInclude(b=>b.Sector).ThenInclude(c=>c.FlightSectors));

        }

        public AircraftScheduleSpecification(DateTime startDate, DateTime endDate)
           : base(x => (x.ScheduleStartDateTime <= startDate && endDate <= x.ScheduleEndDateTime) && !x.IsCompleted && !x.IsDeleted)
        {
            AddInclude(x => x.Include(y => y.Aircraft));
        }

        public AircraftScheduleSpecification(FlightScheduleReportQM query)
            : base(x => query.StartDate == null || (x.ScheduleStartDateTime.Date >= new DateTime(query.StartDate.Value.Year, query.StartDate.Value.Month, 1).Date) &&
                 query.EndDate == null || (x.ScheduleStartDateTime.Date <= new DateTime(query.EndDate.Value.Year, query.EndDate.Value.Month, DateTime.DaysInMonth(query.EndDate.Value.Year, query.EndDate.Value.Month)).Date) &&
                ((query.Month == null && query.Year == null) || (x.ScheduleStartDateTime.Year == query.Year && x.ScheduleStartDateTime.Date.Month == query.Month)) &&
            x.AircraftId.HasValue)
        {
            AddInclude(x => x.Include(y => y.Aircraft));
            AddInclude(x => x.Include(y => y.FlightSchedules).ThenInclude(d=>d.FlightScheduleSectors).ThenInclude(p=>p.Flight).ThenInclude(v=>v.FlightSectors));
        }
    }
}
