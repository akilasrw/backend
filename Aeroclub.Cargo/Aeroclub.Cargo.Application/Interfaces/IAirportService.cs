using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirportRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAirportService
    {
        Task<AirportVM> GetAsync(AirportQM query);
        Task<ServiceResponseCreateStatus> CreateAsync(AirportCreateRM dto);
        Task<bool> DeleteAsync(Guid Id);
        Task<ServiceResponseStatus> UpdateAsync(AirportUpdateRM model);
        Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync();
        Task<Pagination<AirportVM>> GetFilteredListAsync(AirportListQM query);

    }
}