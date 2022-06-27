using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs
{
    public class AircraftSubTypeVM : BaseVM
    { 
        public string Name { get; set; }
        public AircraftSubTypes Type { get; set; }
    }
}
