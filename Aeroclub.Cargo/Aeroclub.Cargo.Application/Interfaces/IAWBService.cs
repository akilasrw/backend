using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IAWBService
    {
        Task<AWBCreateStatusRM> CreateAsync(AWBCreateRM model);
        Task<AWBInformationVM> GetAsync(AirWayBillQM Id);
        Task<ServiceResponseStatus> UpdateAsync(AWBUpdateRM model);

    }
}
