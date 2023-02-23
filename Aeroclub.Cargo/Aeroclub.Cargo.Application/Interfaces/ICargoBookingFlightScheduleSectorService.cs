using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingFlightScheduleSectorRMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoBookingFlightScheduleSectorService
    {
        Task<ServiceResponseCreateStatus> BookingFlightScheduleSectorCreate(CargoBookingFlightScheduleSectorRM rm);
    }
}
