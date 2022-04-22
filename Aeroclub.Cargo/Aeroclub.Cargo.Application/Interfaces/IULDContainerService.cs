using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDContainerService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(ULDContainerDto ULDContainerDto);
        Task<ULDContainerDto> GetAsync(ULDContainerQM query);
    }
}
