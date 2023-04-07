using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;


namespace Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs
{
    public class ULDCreateRM: BaseRM
    {
        [Required(ErrorMessage = "ULD type required")]
        public ULDType ULDType { get; set; }

        [Required(ErrorMessage = "Serial number required")]
        public string SerialNumber { get; set; } = null!;

        [Required(ErrorMessage = "ULD ownership type required")]
        public ULDOwnershipType ULDOwnershipType { get; set; }
        public string? OwnerAirlineCode { get; set; }

        [Required(ErrorMessage = "ULD locate status required")]
        public ULDLocateStatus ULDLocateStatus { get; set; }
        public string? LendAirlineCode { get; set; }

        public Guid ULDMetaDataId { get; set; }

        public ULDMetaDataCreateRM ULDMetaData { get; set; }
    }
}
