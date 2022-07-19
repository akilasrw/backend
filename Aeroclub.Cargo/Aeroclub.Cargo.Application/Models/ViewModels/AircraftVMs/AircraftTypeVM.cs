using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs
{
    public class AircraftTypeVM : BaseVM
    {
        public string Name { get; set; }
        public AircraftTypes Type { get; set; }
        public AircraftConfigType ConfigType { get; set; }

        public IReadOnlyList<AircraftSubTypeVM> AircraftSubTypes { get; set; }
    }
}
