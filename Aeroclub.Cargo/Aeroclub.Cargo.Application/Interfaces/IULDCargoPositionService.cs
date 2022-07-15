

using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDCargoPositionService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerCargoPositionDto ULDContainerCargoPositionDto);

        Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm);


    }
}
