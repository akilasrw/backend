using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.LoadPlanQMs
{
    public class LoadPlanQM: BaseQM
    {
        public bool IncludeAircraftLayout { get; set; }
    }
}
