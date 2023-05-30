using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.LoadPlanVMs
{
    public class LoadPlanVM :BaseVM
    {
        public LoadPlanStatus LoadPlanStatus { get; set; }
        public Guid AircraftLayoutId { get; set; }
        public Guid? SeatLayoutId { get; set; }
        public Guid? OverheadLayoutId { get; set; }

    }
}
