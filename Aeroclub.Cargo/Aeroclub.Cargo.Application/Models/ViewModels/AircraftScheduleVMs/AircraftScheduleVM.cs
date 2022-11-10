using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AircraftScheduleVMs
{
    public class AircraftScheduleVM : BaseVM
    {
        public DateTime ScheduleStartDateTime { get; set; }
        public DateTime ScheduleEndDateTime { get; set; }
        public bool IsCompleted { get; set; }
        public Guid AircraftId { get; set; }
        public string? RegNo { get; set; }
    }
}
