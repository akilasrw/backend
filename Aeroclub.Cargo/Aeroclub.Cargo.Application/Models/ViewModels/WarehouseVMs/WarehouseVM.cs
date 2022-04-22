

using System;

namespace Aeroclub.Cargo.Application.Models.ViewModels.WarehouseVMs
{
    public class WarehouseVM
    {
        public Guid AirportId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
