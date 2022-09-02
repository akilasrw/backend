using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs
{
    public class FlightCreateRM
    {
        [Required(ErrorMessage = "Flight Number is required.")]
        public string FlightNumber { get; set; } = null!;
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string OriginAirportCode { get; set; } = null!;
        public string DestinationAirportCode { get; set; } = null!;
        public string? OriginAirportName { get; set; }
        public string? DestinationAirportName { get; set; }

        public IEnumerable<FlightSectorDto>? FlightSectors { get; set; } = null;
    }
}
