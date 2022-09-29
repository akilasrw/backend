using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using System.ComponentModel.DataAnnotations;


namespace Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs
{
    public class FlightCreateRM: BaseRM
    {
        [Required(ErrorMessage = "Flight Number is required.")]
        public string FlightNumber { get; set; } = null!;

        public IEnumerable<FlightSectorDto>? FlightSectors { get; set; } = null;
    }
}
