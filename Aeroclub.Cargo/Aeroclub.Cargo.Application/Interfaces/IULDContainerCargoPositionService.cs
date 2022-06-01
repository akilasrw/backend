

using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDContainerCargoPositionService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerCargoPositionDto ULDContainerCargoPositionDto);

    }
}
