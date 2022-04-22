using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.RateQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.RateVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IRateService
    {
        Task<Pagination<RateVM>> GetFilteredListAsync(RateSectorQM query);


    }
}
