

using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.SectorRMs
{
    public class SectorCreateRM
    {
        [Required(ErrorMessage = "Origin airport required.")]
        public Guid OriginAirportId { get; set; }

        [Required(ErrorMessage = "Destination airport required.")]
        public Guid DestinationAirportId { get; set; }

        [Required(ErrorMessage = "Sector type required.")]
        public SectorType SectorType { get; set; }

        public bool IsCreateReturnSector { get; set; }
    }
}
