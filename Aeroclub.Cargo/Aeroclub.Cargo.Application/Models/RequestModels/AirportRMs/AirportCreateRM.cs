using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.AirportRMs
{
    public class AirportCreateRM 
    {
       
        [Required(ErrorMessage = "Airport name required.")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Airport code required.")]
        public string Code { get; set; } = null!;
        [Required(ErrorMessage = "Airport latitude required.")]
        public double Lat { get; set; }

        [Required(ErrorMessage = "Airport longitude required.")]
        public double Lon { get; set; }

        [Required(ErrorMessage = "Airport country required.")]
        public Guid CountryId { get; set; }
    }
}
