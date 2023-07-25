using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightScheduleSectorService
    {
        Task<IReadOnlyList<T>> GetListAsync<T>(FlightScheduleSectorListQM query);
        Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleSectorCreateRM dto);
        Task<FlightScheduleSectorVM> GetAsync(FlightScheduleSectorQM query);
        Task<CargoPositionSummaryVM> GetCargoPositionSummaryAsync(FlightScheduleSectorSearchQuery query);
        Task<IEnumerable<SeatDto>> GetCargoPositionLayoutAsync(FlightScheduleSectorSearchQuery query);
        Task<List<FlightScheduleSectorCargoPosition>> GetAircraftAvailableSpace(Guid flightScheduleSectorId);
        Task<List<FlightScheduleSectorCargoPosition>> GetFreighterAircraftAvailableSpace(Guid flightScheduleSectorId);
        Task<double> GetAircraftAvailableVolume(Guid flightScheduleSectorId);
        Task<double> GetAircraftAvailableWeight(Guid flightScheduleSectorId);
        Task<ServiceResponseStatus> DeleteAsync(Guid Id);
        Task<IEnumerable<FlightScheduleSectorUldPositionVM>> GetFlightScheduleSectorWithULDPositionCountAsync(FlightScheduleSectorULDPositionCountQM query);
    }
}