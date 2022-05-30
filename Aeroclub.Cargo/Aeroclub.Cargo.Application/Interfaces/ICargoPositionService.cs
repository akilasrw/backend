using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoPositionService
    {
        Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingCargoPositionAsync(PackageItemRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType);
        Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingThreeSeatCargoPositionAsync(PackageItemRM packageItem, Guid aircraftLayoutId, SeatConfigurationType seatConfigurationType);
        Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm);
    }
}
