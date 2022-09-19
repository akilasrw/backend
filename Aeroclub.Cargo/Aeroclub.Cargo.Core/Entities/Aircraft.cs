using System;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Aircraft : AuditableEntity
    {
        public string RegNo { get; set; } = null!;
        public AircraftTypes AircraftType { get; set; }
        public AircraftSubTypes AircraftSubType { get; set; }
        public AircraftConfigType ConfigurationType { get; set; }
        public AircraftStatus Status { get; set; }
    }
}