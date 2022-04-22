using System;
using System.ComponentModel.DataAnnotations;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class SectorDto : BaseDto
    {
        [Required]
        public Guid? OriginAirportId { get; set; }
        [Required]
        public Guid? DestinationAirportId { get; set; }
        public string? OriginAirportCode { get; set; }
        public string? DestinationAirportCode { get; set; }
        public string? OriginAirportName { get; set; }
        public string? DestinationAirportName { get; set; }
        public SectorType SectorType { get; set; }
    }
}