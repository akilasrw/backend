using Aeroclub.Cargo.Application.Models.Core;
using System.Text.Json.Serialization;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs
{
    public class FlightScheduleManagementDetailQM : BaseQM
    {
        [JsonIgnore]
        public bool IncludeAircraft { get; set; } = false;
    }
}
