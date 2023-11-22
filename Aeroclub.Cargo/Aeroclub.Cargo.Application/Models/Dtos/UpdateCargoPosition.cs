using System;

namespace Aeroclub.Cargo.Application.Models.DTOs
{
    public class UpdateCargoPositionPropertiesDTO
    {
        public Guid CargoPositionId { get; set; }
        public double NewHeight { get; set; }
        public double NewMaxWeight { get; set; }
        public double NewMaxVolume { get; set; }
    }
}