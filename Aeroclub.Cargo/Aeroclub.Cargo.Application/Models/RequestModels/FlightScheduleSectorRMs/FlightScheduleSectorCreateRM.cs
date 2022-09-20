using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs
{
    public class FlightScheduleSectorCreateRM: BaseRM
    {
        [Required(ErrorMessage ="Flight is required.")]
        public Guid FlightId { get; set; }
        [Required(ErrorMessage = "Sector is required.")]
        public Guid SectorId { get; set; }
        public Guid FlightScheduleId { get; set; }
        public int SequenceNo { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ActualDepartureDateTime { get; set; }
        public FlightScheduleStatus FlightScheduleStatus { get; set; } = FlightScheduleStatus.None;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; }
        public string DestinationAirportCode { get; set; }
        public string OriginAirportName { get; set; }
        public string DestinationAirportName { get; set; }
        public string? FlightNumber { get; set; } = null;
        public Guid? LoadPlanId { get; set; } = null;
        public Guid? AircraftId { get; set; } = null;
        public AircraftSubTypes AircraftSubType { get; set; }

    }
}
