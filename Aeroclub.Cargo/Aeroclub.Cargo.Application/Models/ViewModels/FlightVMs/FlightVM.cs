using System;
using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs
{
    public class FlightVM : BaseVM
    {
        public string FlightNumber { get; set; } = null!;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
    }

    public class FlightFilterVM: FlightVM
    {
        public int SectorCount { get; set; }
    }
}