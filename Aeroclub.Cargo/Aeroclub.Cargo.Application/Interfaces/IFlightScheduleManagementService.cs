
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightScheduleManagementService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleManagementRM dto);
        Task<Pagination<FlightScheduleManagementVM>> GetFilteredListAsync(FlightScheduleManagementFilteredListQM query);
        Task<FlightScheduleManagementVM> GetAsync(FlightScheduleManagementDetailQM query);
        Task<bool> DeleteAsync(Guid Id);

    }
}
