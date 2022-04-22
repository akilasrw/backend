using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class CargoAgent : AuditableEntity
    {
        public string AgentName { get; set; } = null!;
        public string Address { get; set; }= null!;
        public string PrimaryTelephoneNumber { get; set; }=null!;
        public string? SecondaryTelephoneNumber { get; set; }
        public string? CargoAccountNumber { get; set; }
        public string City { get; set; }=null !;
        public string? AgentIATACode { get; set; }
        public Guid AppUserId { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;

    }
}
