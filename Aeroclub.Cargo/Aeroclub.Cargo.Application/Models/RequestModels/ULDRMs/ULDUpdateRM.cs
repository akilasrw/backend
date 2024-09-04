using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;


namespace Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs
{
    public class ULDUpdateRM: BaseRM
    {
        public ULDType ULDType { get; set; }
        public string SerialNumber { get; set; } = null!;
        public ULDOwnershipType ULDOwnershipType { get; set; }
        public string? OwnerAirlineCode { get; set; }
        public ULDLocateStatus ULDLocateStatus { get; set; }
        public string? LendAirlineCode { get; set; }

        public Guid? AirportID { get; set; }
        public Guid ULDMetaDataId { get; set; }

        public ULDMetaDataUpdateRM ULDMetaData { get; set; }
    }
}
