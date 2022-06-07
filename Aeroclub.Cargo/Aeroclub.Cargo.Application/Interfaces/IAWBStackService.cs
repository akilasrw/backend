using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBStackRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBStackVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAWBStackService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(AWBStackRM dto);
        Task<AWBStackVM> GetAsync(AWBStackQM query);
        Task<Pagination<AWBStackVM>> GetAWBStackFilteredListAsync(AWBStackListQM query);
        Task<AWBStackVM> GetLastRecordAsync();
        Task<AWBNumbeStackVM> GetNextAWBNumberAsync(AWBNumberStackQM query);
        Task<ServiceResponseStatus> UpdateUsedAWBNumberAsync(AWBStackUpdateRM dto);

    }

}
