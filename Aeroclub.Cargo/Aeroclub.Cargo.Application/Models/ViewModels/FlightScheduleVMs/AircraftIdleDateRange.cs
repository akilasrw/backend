namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs
{
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
