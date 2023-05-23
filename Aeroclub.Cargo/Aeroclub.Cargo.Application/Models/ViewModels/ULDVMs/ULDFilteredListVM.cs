using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;


namespace Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs
{
    public class ULDFilteredListVM : BaseVM
    {
        public ULDType ULDType { get; set; }
        public string? SerialNumber { get; set; }
        public ULDOwnershipType ULDOwnershipType { get; set; }
        public string? OwnerAirlineCode { get; set; }
        public ULDLocateStatus ULDLocateStatus { get; set; }
        public string? LendAirlineCode { get; set; }
        public DateTime LastUsedDate { get; set; }
        public string? LastUsedFlightNumber { get; set; }
        public string? LastLocatedAirportCode { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double MaxWeight { get; set; }
        public double MaxVolume { get; set; }
        public Guid ULDMetaDataId { get; set; }
    }
}
