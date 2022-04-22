using Aeroclub.Cargo.Application.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs
{
    public class CargoAgentCreateRM : BaseRM
    {
        [Required(ErrorMessage = "Aagent name required")]
        public string AgentName { get; set; } = null!;

        [Required(ErrorMessage = "Username required")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Address required")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "Telephone number required")]
        public string PrimaryTelephoneNumber { get; set; } = null!;
        public string? SecondaryTelephoneNumber { get; set; }

        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }= null!;
        public string? CargoAccountNumber { get; set; }

        [Required(ErrorMessage = "Country Id required")]
        public Guid CountryId { get; set; }

        [Required(ErrorMessage = "City required")]
        public string City { get; set; } = null!;
        public string? AgentIATACode { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Confirm Password required")]
        public string ConfirmPassword { get; set; } = null!;
       
        
        
    }
}
