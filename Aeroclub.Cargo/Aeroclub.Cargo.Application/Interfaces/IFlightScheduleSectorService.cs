using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightScheduleSectorService
    {
        Task<IReadOnlyList<T>> GetListAsync<T>(FlightScheduleSectorListQM query);
        Task<Pagination<FlightScheduleSectorVM>> GetFilteredListAsync(FlightScheduleSectorFilteredListQM query);
        Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleSectorCreateRM dto);
        Task<FlightScheduleSectorVM> GetAsync(FlightScheduleSectorQM query);
        Task<CargoPositionSummaryVM> GetCargoPositionSummaryAsync(FlightScheduleSectorSearchQuery query);
        Task<IEnumerable<SeatDto>> GetCargoPositionLayoutAsync(FlightScheduleSectorSearchQuery query);
    }
}