

using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDCargoPositionService
    {
        Task<CargoPosition> GetMatchingCargoPositionAsync(PackageItemCreateRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType);
        Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm);
        Task<ServiceResponseCreateStatus> CreateAsync(List<ULDCargoPositionDto> ULDCargoPositionDto);

    }
}
