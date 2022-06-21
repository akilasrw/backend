using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs
{
    public class SectorVM : BaseVM
    {
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
        public string? OriginAirportCode { get; set; }
        public string? DestinationAirportCode { get; set; }
        public string? OriginAirportName { get; set; }
        public string? DestinationAirportName { get; set; }
        public SectorType SectorType { get; set; }
    }
}
