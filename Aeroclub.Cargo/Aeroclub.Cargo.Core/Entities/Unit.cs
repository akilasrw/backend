using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Unit : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public UnitType UnitType { get; set; }
    }
}