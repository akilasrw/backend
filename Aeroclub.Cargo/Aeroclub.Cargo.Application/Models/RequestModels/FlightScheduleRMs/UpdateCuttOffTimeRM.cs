using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs
{
    public class UpdateCutOffTimeRM : BaseRM
    {
        public Guid? FlightId { get; set; }
        //public double CutOffTimeMin { get; set; }
        public DateTime CutOffTime { get; set; }
    }
}
