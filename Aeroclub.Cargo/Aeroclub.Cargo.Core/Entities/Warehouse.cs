using System;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Warehouse : AuditableEntity
    {
        public Guid AirportId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Airport Airport { get; set; }
    }
}
