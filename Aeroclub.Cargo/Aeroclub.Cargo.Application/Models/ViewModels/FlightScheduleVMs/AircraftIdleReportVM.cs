using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs
{
    public class AircraftIdleReportVM
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public double NoOfHours { get; set; }
        public string AircraftRegNo { get; set; }
        public Guid AircraftId { get; set; }

        public double? TotalFlightTimeHrs { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public ScheduleStatus ScheduleStatus { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public List<Tuple<DateTime,DateTime, double>> IdleDateRangeList { get; set; } // TODO: remove
        public IEnumerable<AircraftIdleDateRange> AircraftIdleDateRangeList { get; set; }
    }

    public class AircraftIdleDateRange
    {
        public AircraftIdleDateRange()
        {

        }

        //public AircraftIdleDateRange(AircraftIdleDateRange aircraftIdleDateRange) : this()
        //{
        //    StartTime = aircraftIdleDateRange.StartTime;
        //    EndTime = aircraftIdleDateRange.EndTime;
        //    TotalHours = aircraftIdleDateRange.TotalHours;
        //}

        public AircraftIdleDateRange(DateTime startTime, DateTime endTime, double totalHours): this()
        {
            StartTime= startTime;
            EndTime = endTime;
            TotalHours= totalHours;
        }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double TotalHours { get; set; }
    }
}
