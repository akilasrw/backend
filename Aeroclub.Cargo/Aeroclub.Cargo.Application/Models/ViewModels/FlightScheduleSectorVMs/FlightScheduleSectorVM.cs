using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs
{
    public class FlightScheduleSectorVM : BaseVM
    {
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string OriginAirportName { get; set; } = null!;
        public string DestinationAirportName { get; set; } = null!;
        public string? FlightNumber { get; set; } = null;
        public double AvailableWeight{ get; set; }
        public double AvailableVolume{ get; set; }
        public AircraftConfigType AircraftConfigType { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public DateTime? BookingCutoffTime { get; set; }
        public DateTime? AcceptanceCutoffTime { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public Guid? AircraftLayoutId { get; set; }
        public Guid? SeatLayoutId { get; set; }
        public Guid? LoadPlanId { get; set; } = null;


        public IList<FlightScheduleSectorCargoPosition> FlightScheduleSectorCargoPositions { get; set; }
    }
}