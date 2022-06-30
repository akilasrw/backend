using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

using System.ComponentModel.DataAnnotations;


namespace Aeroclub.Cargo.Application.Models.RequestModels.AircraftRMs
{
    public class AircaftUpdateRM : BaseRM
    {
        [Required(ErrorMessage = "Aircraft register number required.")]
        public string RegNo { get; set; } = null!;

        [Required(ErrorMessage = "Aircraft type required.")]
        public Guid AircraftTypeId { get; set; }

        [Required(ErrorMessage = "Aircraft sub type required.")]
        public Guid AircraftSubTypeId { get; set; }

        [Required(ErrorMessage = "Aircraft configuration type required.")]
        public AircraftConfigType ConfigurationType { get; set; }

        [Required(ErrorMessage = "Aircraft status required.")]
        public AircraftStatus Status { get; set; }
        public bool IsActive { get; set; }

    }
}
