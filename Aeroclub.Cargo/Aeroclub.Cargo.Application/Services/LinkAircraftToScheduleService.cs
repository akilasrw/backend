using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.LIRFileUploadQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.FileUploader.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class LinkAircraftToScheduleService : BaseService, ILinkAircraftToScheduleService
    {
        private readonly IFlightScheduleService _flightScheduleService;
        private readonly IAircraftService _aircraftService;
        private readonly ILIRFileUploadService _lIRFileUploadService;
        private readonly IUploadFactory _uploadFactory;
        private readonly ICargoBookingSummaryService _cargoBookingSummaryService;
        private readonly INotificationService _notificationService;

        public LinkAircraftToScheduleService(IUnitOfWork unitOfWork,
            IMapper mapper, 
            IFlightScheduleService flightScheduleService,
            ICargoBookingSummaryService cargoBookingSummaryService,
            IAircraftService aircraftService,
            ILIRFileUploadService lIRFileUploadService,
            INotificationService notificationService,
            IUploadFactory uploadFactory) 
            : base(unitOfWork, mapper)
        {
            _flightScheduleService = flightScheduleService;
            _aircraftService = aircraftService;
            _lIRFileUploadService = lIRFileUploadService;
            _uploadFactory = uploadFactory;
            _cargoBookingSummaryService = cargoBookingSummaryService;
            _notificationService = notificationService;
        }
        public async Task<ServiceResponseStatus> CreateAsync(ScheduleAircraftRM query)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                var status = ServiceResponseStatus.Success;
                bool edited = false;
                var spec = new FlightScheduleSpecification(new FlightScheduleLinkQM { FlightScheduleId = query.FlightScheduleId, IncludeFlightScheduleSectors = true, IncludeAircrafts = true });
                var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);
                if (flightSchedule != null)
                {

                    var fs = flightSchedule.ActualArrivalDateTime == null ? flightSchedule.ScheduledDepartureDateTime : flightSchedule.ActualArrivalDateTime.Value;
                    if (query.StepCount == 1)
                    {
                        if (!await ValidAircraftAsync(query))
                            return ServiceResponseStatus.ValidationError;

                        flightSchedule.AircraftId = query.AircraftId;
                        flightSchedule.AircraftRegNo = await _aircraftService.GetAircraftRegNo(query.AircraftId);
                        flightSchedule.AircraftScheduleId = query.AircraftScheduleId;

                        flightSchedule.EstimatedDepartureDateTime = fs.Date.Add(TimeSpan.Parse(query.EstimatedDepartureDateTime));
                        flightSchedule.EstimatedArrivalDateTime = fs.Date.Add(TimeSpan.Parse(query.EstimatedArrivalDateTime));
                        flightSchedule.IsHistory = flightSchedule.ActualArrivalDateTime == null ? false : true;
                        edited = true;

                    }
                    else if (query.StepCount == 2)
                    {
                        flightSchedule.ActualDepartureDateTime = fs.Date.Add(TimeSpan.Parse(query.ActualDepartureDateTime));
                        flightSchedule.IsDispatched = query.IsDispatched.Value;
                        await CreateNotification(flightSchedule);

                        edited = true;
                    }
                }

                if (edited)
                {
                    _unitOfWork.Repository<FlightSchedule>().Update(flightSchedule);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<FlightSchedule>().Detach(flightSchedule);

                    var specSector = new FlightScheduleSectorSpecification(new FlightScheduleSectorSearchQuery() { FlightScheduleId = query.FlightScheduleId });
                    var flightScheduleSectors = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(specSector);
                    int sectorCount = 0;
                    foreach (var sector in flightScheduleSectors)
                    {
                        sectorCount++;
                        sector.AircraftId = query.AircraftId;
                        if (sectorCount == 1)
                        {
                            if (query.StepCount == 1)
                                sector.EstimatedDepartureDateTime = flightSchedule.EstimatedDepartureDateTime;
                            if (query.StepCount == 2)
                                sector.ActualDepartureDateTime = flightSchedule.ActualDepartureDateTime;
                        }

                        if (flightScheduleSectors.Count == sectorCount && query.StepCount == 1)
                            sector.EstimatedArrivalDateTime = flightSchedule.EstimatedArrivalDateTime;

                        _unitOfWork.Repository<FlightScheduleSector>().Update(sector);
                        await _unitOfWork.SaveChangesAsync();
                        _unitOfWork.Repository<FlightScheduleSector>().Detach(sector);
                    }
                }
                
                transaction.Commit();
                
                return status;
            }

        }

        public async Task<bool> UploadLIRAsync(UploadLIRFileRM query)
        {
            if (query.File != null)
            {
                var service = _uploadFactory.CreateUploadServiceAsync(UploadStorageType.Blob);
                var uploadedFile = service.Upload(query.File);
                var savedLIRFileUpload = await _lIRFileUploadService.GetAsync(new LIRFileUploadQM() { FlightScheduleId = query.FlightScheduleId });
                
                if (savedLIRFileUpload == null) // no records
                {
                    await _lIRFileUploadService.CreateAsync(
                    new LIRFileUploadDto()
                    {
                        Extesnsion = Path.GetExtension(query.File.FileName),
                        FileName = uploadedFile.FileName,
                        OriginalFileName = uploadedFile.OriginalFileName,
                        FlightScheduleId = query.FlightScheduleId,
                        FileFullURL = uploadedFile.AbsoluteURL,
                        FileURLPath = ""
                    });
                    return true;

                }
                else
                {
                    savedLIRFileUpload.Extesnsion = Path.GetExtension(query.File.FileName);
                    savedLIRFileUpload.FileName = uploadedFile.FileName;
                    savedLIRFileUpload.OriginalFileName = uploadedFile.OriginalFileName;
                    savedLIRFileUpload.FileFullURL = uploadedFile.AbsoluteURL;

                    await _lIRFileUploadService.UpdateAsync(savedLIRFileUpload);
                    return true;
                }                 
            }
            return false;
        }

        public async Task<Pagination<FlightScheduleLinkAircraftVM>> GetLinkAircraftFilteredListAsync(FlightScheduleManagemenLinktFilteredListQM query)
        {
            var spec = new FlightScheduleSpecification(query);
            var flightScheduleList = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(spec);

            var countSpec = new FlightScheduleSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<FlightSchedule>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<FlightScheduleLinkAircraftVM>>(flightScheduleList);
            foreach (var fs in dtoList)
            {
                var sum = await _cargoBookingSummaryService.GetAsync(new CargoBookingSummaryDetailQM() { Id = fs.Id, IsIncludeFlightScheduleSectors = true });
                fs.TotalWeight = sum.CargoPositionSummary.TotalBookedWeight;
                fs.OffLoadCount = sum.BookingSummaryDetailFigures.OffLoadCount;
                fs.ActualLoadCount = sum.BookingSummaryDetailFigures.ActualLoadCount;
            }
            return   new Pagination<FlightScheduleLinkAircraftVM>(query.PageIndex, query.PageSize, totalCount, dtoList);;
        }

        private async Task<bool> ValidAircraftAsync(ScheduleAircraftRM query)
        {
            bool valid = false;
            IReadOnlyList<AircraftDto> availableAircrafts = await _flightScheduleService.GetAvailableAircrafts_ByFlightScheduleIdAsync(query.FlightScheduleId);
            if (availableAircrafts.Where(x => x.Id == query.AircraftId).ToList().Count() > 0)
                valid = true;

            var fsSpec = new FlightScheduleSpecification(query.AircraftScheduleId.Value); // Get FlightSchedule from aircraft Schedule Id. 
            IReadOnlyList<FlightSchedule> flightSchedule_AlreadyLinked = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(fsSpec);

            if (flightSchedule_AlreadyLinked == null || flightSchedule_AlreadyLinked.Count == 0)
                valid = true;

            return valid;
        }

        public async Task<bool> IsBookingsVerifiedAsync(VerifyScheduleAicraftRM rm)
        {
            var spec = new FlightScheduleSpecification(new CargoBookingSummaryDetailQM() { IsIncludeFlightScheduleSectors = true, Id = rm.FlightScheduleId });
            var flightSchedule = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(spec);

            foreach (var flightScheduleSectors in flightSchedule.FlightScheduleSectors)
            {
                if (flightScheduleSectors.CargoBookingFlightScheduleSectors == null || flightScheduleSectors.CargoBookingFlightScheduleSectors.Count() == 0)
                    return false;
                else
                {
                    foreach (var booking in flightScheduleSectors.CargoBookingFlightScheduleSectors)
                    {
                        if (booking.CargoBooking.BookingStatus == BookingStatus.Accepted &&
                            (booking.CargoBooking.VerifyStatus != VerifyStatus.ActualLoad && 
                            booking.CargoBooking.VerifyStatus != VerifyStatus.OffLoad))
                        {
                            return false;
                        }

                        if ((booking.CargoBooking.BookingStatus == BookingStatus.Booked && booking.CargoBooking.VerifyStatus == VerifyStatus.None) || 
                            (booking.CargoBooking.BookingStatus == BookingStatus.None && booking.CargoBooking.VerifyStatus == VerifyStatus.None))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        async Task CreateNotification(FlightSchedule flightSchedule)
        {
            var flightDate = flightSchedule.ActualDepartureDateTime.ToString("g");
            var flightNumber = flightSchedule.FlightNumber;
            var airportCode = flightSchedule.OriginAirportCode;
            var destinationAirportCode = flightSchedule.DestinationAirportCode;
            foreach (var flightScheduleSectors in flightSchedule.FlightScheduleSectors)
            {
                if (flightScheduleSectors.CargoBookingFlightScheduleSectors != null || flightScheduleSectors.CargoBookingFlightScheduleSectors.Count() != 0)
                    
                    foreach (var booking in flightScheduleSectors.CargoBookingFlightScheduleSectors)
                    {
                        var awbNumber = booking.CargoBooking.AWBInformation?.AwbTrackingNumber;
                        NotificationRM notificationRM = new NotificationRM();
                        notificationRM.NotificationType = Common.Enums.NotificationType.Flight_Dispatched;
                        notificationRM.Title = "Flight has departed from " + airportCode + " with you cargo for AWB " + awbNumber;
                        notificationRM.Body = "Flight details; " + flightNumber + " - " + airportCode + " - " + destinationAirportCode + ",Flight Date time ; " + flightDate + ", ";
                        await _notificationService.CreateAsync(notificationRM);
                    }
                
            }
        }
    }
}
