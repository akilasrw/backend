using System;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Airport : AuditableEntity
    {
        public string Name { get; set; }  = null!;
        public string Code { get; set; }  = null!;
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}