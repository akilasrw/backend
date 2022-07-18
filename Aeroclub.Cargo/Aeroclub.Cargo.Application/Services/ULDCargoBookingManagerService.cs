

using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDCargoBookingManagerService : BaseService, IULDCargoBookingManagerService
    {
        private readonly IULDCargoBookingService _uldCargoBookingService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;

        public ULDCargoBookingManagerService(IUnitOfWork unitOfWork, IMapper mapper, IULDCargoBookingService uldCargoBookingService, IFlightScheduleSectorService flightScheduleSectorService) :
            base(unitOfWork, mapper)
        {
            _uldCargoBookingService = uldCargoBookingService;
            _flightScheduleSectorService = flightScheduleSectorService;

        }

        public async Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                var packages = rm.PackageItems.ToList();
                rm.PackageItems.Clear();

                // Get Flight Schedule Sector Data
                var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = rm.FlightScheduleSectorId.Value, IncludeLoadPlan = true });
                rm.OriginAirportId = flightSector.OriginAirportId;
                rm.DestinationAirportId = flightSector.DestinationAirportId;

                // Save Cargo Booking Details
                var response = await _uldCargoBookingService.CreateAsync(rm);
                if (response.StatusCode == ServiceResponseStatus.Failed)
                {
                    transaction.Rollback();
                    return BookingServiceResponseStatus.Failed;
                }
                transaction.Commit();
            }

            return BookingServiceResponseStatus.Success;
        }

        public async Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query)
        {
            return await _uldCargoBookingService.GetAsync(query);
        }
    }
}
