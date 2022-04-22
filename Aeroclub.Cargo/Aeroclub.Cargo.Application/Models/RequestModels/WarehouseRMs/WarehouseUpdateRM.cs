using System;
using Aeroclub.Cargo.Application.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.WarehouseRMs
{
    public class WarehouseUpdateRM : BaseRM
    {
        [Required]
        public Guid AirportId { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
