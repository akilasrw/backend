using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.AirportQMs
{
    public class AirportQM : BaseQM
    {
        public bool IsCountryInclude { get; set; } = false;
    }
}
