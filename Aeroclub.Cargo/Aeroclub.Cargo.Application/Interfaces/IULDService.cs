using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IULDService
    {
        Task<ServiceResponseCreateStatus> CreateULDAsync(ULDDto ULDDto);
        Task<ServiceResponseCreateStatus> CreateAsync(ULDCreateRM ULDDto);
        Task<ULDDto> GetAsync(ULDQM query);
    }
}
