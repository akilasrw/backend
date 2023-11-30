using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs
{
    public class FlightScheduleSectorPalletCreateRM : BaseRM
    {
        public Guid FlightScheduleSectorId { get; set; }
        public Guid ULDId { get; set; }
    }
    public class FlightScheduleSectorPalletCreateRemoveRM : FlightScheduleSectorPalletCreateRM
    {
        public bool IsAdded { get; set; }
    }

    public class FlightSheduleSectorPalletGetList : BaseRM
    {
        public Guid FlightScheduleId { get; set; }
        public ULDLocateStatus? ULDLocateStatus { get; set; }
        public Guid? ULDId { get; set; }
    }
    
    public class FlightScheduleSectorPalletCreateListRM
    {
        public IEnumerable<FlightScheduleSectorPalletCreateRemoveRM> FlightScheduleSectorPalletRMs { get; set; }
    }

    
}
