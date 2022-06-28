using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.Queries.AircraftQMs
{
    public class AircraftListQM : BasePaginationQM
    {
        public bool? IsActive { get; set; }
        public string? RegNo { get; set; } = null;
        public AircraftTypes AircraftType { get; set; }
    }
}
