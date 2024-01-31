﻿using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.GetShipmentsRM;
using Aeroclub.Cargo.Application.Models.ViewModels.BookingShipmentSummeryVM;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoBookingService
    {
        Task<Pagination<CargoBookingVM>> GetFilteredListAsync(CargoBookingFilteredListQM query);
        Task<CargoBookingDetailVM> GetAsync(CargoBookingDetailQM query);
        Task<CargoBookingDetailVM> GetDetailAsync(CargoBookingQM query);
        Task<ServiceResponseCreateStatus> CreateAsync(CargoBookingRM dto);
        Task<ServiceResponseStatus> UpdateAWBStatus(Guid bookingId);
        Task<ServiceResponseCreateStatus> UpdateAsync(CargoBookingUpdateRM rm);
        Task<IReadOnlyList<CargoBookingListVM>> GetListAsync(FlightScheduleSectorBookingListQM query);
        Task<IReadOnlyList<CargoBookingListVM>> GetOnlyAssignedListAsync(AssignedCargoQM query);
        Task<IReadOnlyList<CargoBookingULDVM>> GetFreighterBookingListAsync(FlightScheduleSectorBookingListQM query);
        Task<ServiceResponseStatus> UpdateDeleteListAsync(IEnumerable<CargoBookingUpdateRM> list);
        Task<ServiceResponseStatus> UpdateStandByStatusAsync(CargoBookingStatusUpdateListRM rm);
        Task<IReadOnlyList<CargoBookingStandByCargoVM>> GetStandByCargoListAsync(FlightScheduleSectorBookingListQM query);
        Task<IReadOnlyList<CargoBookingListVM>> GetVerifyBookingListAsync(FlightScheduleSectorVerifyBookingListQM query);
        Task<CargoBookingMobileVM> GetMobileBookingAsync(FlightScheduleSectorMobileQM query);
        Task<IReadOnlyList<BookingShipmentSummeryVM>> GetShipmentsByAWB(GetShipmentsRM rm);


    }
}