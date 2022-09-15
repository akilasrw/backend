using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightScheduleService
    {
        Task<FlightScheduleCreateStatusRM> CreateAsync(FlightScheduleCreateRM model);
        Task<ServiceResponseStatus> UpdateAsync(FlightScheduleUpdateRM model);
        Task<FlightScheduleVM> GetAsync(FlightScheduleQM query);
        Task<IReadOnlyList<FlightScheduleVM>> GetListAsync();
    }
}