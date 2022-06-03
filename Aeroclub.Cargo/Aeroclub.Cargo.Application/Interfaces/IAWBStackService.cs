using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBStackVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAWBStackService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(AWBStackRM dto);
        Task<AWBStackVM> GetAsync(AWBStackQM query);
        Task<Pagination<AWBStackVM>> GetBookingFilteredListAsync(AWBStackListQM query);
        Task<AWBStackVM> GetLastRecordAsync();

    }

}
