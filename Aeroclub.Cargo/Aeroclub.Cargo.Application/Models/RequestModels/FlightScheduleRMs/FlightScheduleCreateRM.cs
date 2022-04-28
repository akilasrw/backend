using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs
{
    public class FlightScheduleCreateRM: BaseRM
    {
        public Guid? FlightId { get; set; } 
        public string? FlightNumber { get; set; } = null;
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public FlightScheduleStatus FlightScheduleStatus { get; set; } = FlightScheduleStatus.None;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public Guid? AircraftId { get; set; }
        public string? AircraftRegNo { get; set; } = null;

        public IEnumerable<FlightScheduleSectorCreateRM>? FlightScheduleSectors { get; set; }
    }
}