using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.SectorQMs
{
    public class SectorListQM : BasePaginationQM
    {
        public SectorType SectorType { get; set; }
        public Guid OriginAirportId { get; set; }
        public Guid DestinationAirportId { get; set; }
    }
    public class SectorSelectListQM
    {
        public SectorType SectorType { get; set; } =  SectorType.None;
    }
}
