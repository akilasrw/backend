using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs
{
    public class AgentProfileUpdateRM : BaseRM
    {

        [Required(ErrorMessage = "Aagent name required")]
        public string AgentName { get; set; } = null!;

        [Required(ErrorMessage = "Username required")]
        public string UserName { get; set; } = null!;

       
        public string PrimaryTelephoneNumber { get; set; } = null!;
        public string? SecondaryTelephoneNumber { get; set; }

        public string? Email { get; set; } = null!;
        


 

    }
}
