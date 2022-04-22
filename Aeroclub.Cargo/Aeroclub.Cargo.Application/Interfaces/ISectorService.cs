using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ISectorService
    {
        Task<ServiceResponseStatus> CreateAsync(SectorDto sectorDto);
        Task<SectorDto> GetAsync(SectorQM query);
    }
}