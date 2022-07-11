using System;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Airport : AuditableEntity
    {
        public string Name { get; set; }  = null!;
        public string Code { get; set; }  = null!;
        public double Lat { get; set; }
        public double Lon { get; set; }
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}