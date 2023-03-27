using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs
{
    public class UploadLIRFileRM
    {
        [Required]
        public Guid FlightScheduleId { get; set; }
        [Required]
        public IFormFile? File { get; set; }
    }
}
