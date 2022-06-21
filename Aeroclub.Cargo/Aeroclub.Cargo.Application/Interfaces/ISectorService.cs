using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ISectorService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(SectorCreateRM model);
        Task<ServiceResponseStatus> UpdateAsync(SectorUpdateRM model);
        Task<SectorVM> GetAsync(SectorQM query);
        Task<Pagination<SectorVM>> GetFilteredListAsync(SectorListQM query);
        Task<bool> DeleteAsync(Guid Id);

    }
}