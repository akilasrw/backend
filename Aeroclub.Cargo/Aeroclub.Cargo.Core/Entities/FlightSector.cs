using System;

namespace Aeroclub.Cargo.Core.Entities
{
    public class FlightSector
    {
        public Guid FlightId { get; set; }
        public Guid SectorId { get; set; }
        public int Sequence { get; set; }
        
        public virtual Flight Flight { get; set; }
        public virtual Sector Sector { get; set; }
    }
}