using System;
using System.Collections.Generic;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs
{
    public class CargoBookingRM
    {
        public BookingStatus BookingStatus { get; set; }
        public Guid? FlightScheduleSectorId { get; set; }
        public Guid? OriginAirportId { get; set; }
        public Guid? DestinationAirportId { get; set; }
        public List<PackageItemCreateRM> PackageItems { get; set; }
    }
}