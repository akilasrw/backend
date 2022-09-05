
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightScheduleManagementService
    {
        Task<Pagination<FlightScheduleManagementVM>> GetFilteredListAsync(FlightScheduleManagementFilteredListQM query);

    }
}
