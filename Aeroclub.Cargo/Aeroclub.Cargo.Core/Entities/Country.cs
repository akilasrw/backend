using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Country : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;

        public virtual ICollection<CargoAgent> Agents { get; set; }
        public virtual ICollection<SystemUser> SystemUsers { get; set; }
    }
}