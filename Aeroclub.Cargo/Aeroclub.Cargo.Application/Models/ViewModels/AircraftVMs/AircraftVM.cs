

using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs
{
    public class AircraftVM : BaseVM
    {
        public string RegNo { get; set; } = null!;
        public AircraftTypes AircraftType { get; set; }
        public AircraftSubTypes AircraftSubType { get; set; }
        public AircraftConfigType ConfigurationType { get; set; }
        public AircraftStatus Status { get; set; }
        public bool IsActive { get; set; }
       
    }
}
