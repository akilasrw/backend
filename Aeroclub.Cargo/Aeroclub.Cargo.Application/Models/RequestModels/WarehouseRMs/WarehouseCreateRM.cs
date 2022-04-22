using System;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.WarehouseRMs
{
    public class WarehouseCreateRM
    {
        [Required]
        public Guid AirportId { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
