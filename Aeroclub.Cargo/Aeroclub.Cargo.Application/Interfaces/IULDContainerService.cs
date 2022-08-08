using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainer;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDContainerService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerDto ULDContainerDto);
        Task<ULDContainerDto> GetAsync(ULDContainerQM query);
        Task<ServiceResponseStatus> UpdateAsync(ULDContainerUpdateRM dto);

    }
}
