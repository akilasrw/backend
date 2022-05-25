using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoPositionService
    {
        Task<Tuple<CargoPosition, Guid?>> GetMatchingCargoPositionAsync(PackageItemRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType);
        Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm);
    }
}
