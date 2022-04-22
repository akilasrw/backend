
namespace Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs
{
    public class CargoAgentVM
    {
       // public Guid Id { get; set; }
        public string AgentName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PrimaryTelephoneNumber { get; set; } = null!;
        public string? SecondaryTelephoneNumber { get; set; }
        public string Email { get; set; } = null!;
        public string? CargoAccountNumber { get; set; }
        public Guid CountryId { get; set; }
        public Guid AppUserId { get; set; }
        public string? CountryName { get; set; }
        public string City { get; set; } = null!;
        public string? AgentIATACode { get; set; }
  
    }
}
