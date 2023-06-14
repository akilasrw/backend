using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class ULDDto: BaseDto
    {
        public ULDType ULDType { get; set; }
        public string SerialNumber { get; set; } = null!;
        public ULDOwnershipType ULDOwnershipType { get; set; }
        public string? OwnerAirlineCode { get; set; }
        public ULDLocateStatus ULDLocateStatus { get; set; }
        public string? LendAirlineCode { get; set; }
        public Guid ULDMetaDataId { get; set; }

        public ULDMetaDataDto ULDMetaData { get; set; }
    }
}
