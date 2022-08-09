using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerCargoPositionVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDContainerCargoPositionService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerCargoPositionDto ULDContainerCargoPositionDto);
        Task<IReadOnlyList<ULDContainerCargoPositionVM>> GetListAsync(ULDCOntainerCargoPositionQM query);

    }
}
