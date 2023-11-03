using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDMetaDataVMs;
using Aeroclub.Cargo.Common.Enums;


namespace Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs
{
    public class ULDVM : BaseVM
    {
        public ULDType ULDType { get; set; }
        public string? SerialNumber { get; set; }
        public Guid ULDMetaDataId { get; set; }
        public ULDOwnershipType ULDOwnershipType { get; set; }
        public string? OwnerAirlineCode { get; set; }
        public ULDLocateStatus ULDLocateStatus { get; set; }
        public string? LendAirlineCode { get; set; }

        public ULDMetaDataVM ULDMetaData { get; set; }
    }
}
