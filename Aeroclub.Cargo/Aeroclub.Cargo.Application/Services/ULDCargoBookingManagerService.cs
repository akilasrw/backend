using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.PackageULDContainerQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingFlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageULDContainerRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainer;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainerCargoPositionRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDCargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerCargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Google.Type;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDCargoBookingManagerService : BaseService, IULDCargoBookingManagerService
    {
        private readonly IULDCargoBookingService _uldCargoBookingService;
        private readonly ICargoBookingFlightScheduleSectorService _cargoBookingFlightScheduleSectorService;
        private readonly IFlightScheduleSectorPalletService _flightScheduleSectorPalletService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly IULDContainerCargoPositionService _uLDContainerCargoPositionService;
        private readonly IConfiguration _configuration;
        private readonly IULDContainerService _uldContainerService;
        private readonly IPackageItemService _packageItemService;
        private readonly IAWBService _AWBService;
        private readonly IBaseUnitConverter _baseUnitConverter;
        private readonly ICargoAgentService _cargoAgentService;
        private readonly INotificationService _notificationService;

        public ULDCargoBookingManagerService(IUnitOfWork unitOfWork,
            IMapper mapper,
            IULDCargoBookingService uldCargoBookingService,
            IFlightScheduleSectorService flightScheduleSectorService,
            IULDCargoPositionService uldcgoPositionService,
            IULDContainerCargoPositionService uLDContainerCargoPositionService,
            IULDContainerService uldcontainerService,
            IPackageItemService packageItemService,
            IAssignCargoToULDService assignCargoToULDService,
            IAWBService AWBService,
            IConfiguration configuration,
            ICargoAgentService cargoAgentService,
            ICargoBookingFlightScheduleSectorService cargoBookingFlightScheduleSectorService,
            IFlightScheduleSectorPalletService flightScheduleSectorPalletService,
            INotificationService notificationService,
        IBaseUnitConverter baseUnitConverter) :
            base(unitOfWork, mapper)
        {
            _cargoBookingFlightScheduleSectorService = cargoBookingFlightScheduleSectorService;
            _flightScheduleSectorPalletService = flightScheduleSectorPalletService;
            _uldCargoBookingService = uldCargoBookingService;
            _flightScheduleSectorService = flightScheduleSectorService;
            _uLDContainerCargoPositionService = uLDContainerCargoPositionService;
            _configuration = configuration;
            _uldContainerService = uldcontainerService;
            _packageItemService = packageItemService;
            _AWBService = AWBService;
            _baseUnitConverter = baseUnitConverter;
            _cargoAgentService = cargoAgentService;
            _notificationService = notificationService;
        }

        public async Task<BookingServiceResponseStatus> CreateAsync(CargoBookingRM rm) // for onFloor 
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                if (rm.FlightScheduleSectorIds == null)
                {
                    return BookingServiceResponseStatus.ValidationError;
                }

                var packages = rm.PackageItems.ToList();
                double totalWeight = 0;
                var flightSectors = new List<FlightScheduleSectorVM>();
                rm.PackageItems.Clear();

                // Save Cargo Booking Details
                var cargoBooking = await _uldCargoBookingService.CreateAsync(rm);
                if (cargoBooking.StatusCode == ServiceResponseStatus.Failed)
                {
                    transaction.Rollback();
                    return BookingServiceResponseStatus.Failed;
                }

                foreach (var flightSectorId in rm.FlightScheduleSectorIds)
                {
                    var createdBookingFlightSector = await _cargoBookingFlightScheduleSectorService.BookingFlightScheduleSectorCreate(new CargoBookingFlightScheduleSectorRM() { CargoBookingId = cargoBooking.Id, FlightScheduleSectorId = flightSectorId });
                    if (createdBookingFlightSector.StatusCode == ServiceResponseStatus.Failed)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.Failed;
                    }
                }

                //Save AWB Details
                if (rm.AWBDetail != null)
                {
                    rm.AWBDetail.CargoBookingId = cargoBooking.Id;
                    var awbResponse = await _AWBService.CreateAsync(rm.AWBDetail);

                    if (awbResponse.StatusCode == ServiceResponseStatus.ValidationError)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.NoAwb;
                    }

                    if (awbResponse.StatusCode == ServiceResponseStatus.Failed)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.Failed;
                    }
                }

                //Packages clone based on number of pieces
                var clonedPackages = new List<PackageItemCreateRM>();
                foreach (var package in packages)
                {
                    for (int i = 0; i < package.Pieces; i++)
                    {
                        var clonePackage = new PackageItemCreateRM();
                        clonePackage = package;
                        clonedPackages.Add(clonePackage);
                    }
                }

                foreach (var package in clonedPackages)
                {

                    //Package volume calculation
                    package.Length = await _baseUnitConverter.VolumeCalculatorAsync(package.Length, package.VolumeUnitId);
                    package.Width = await _baseUnitConverter.VolumeCalculatorAsync(package.Width, package.VolumeUnitId);
                    package.Height = await _baseUnitConverter.VolumeCalculatorAsync(package.Height, package.VolumeUnitId);
                    package.Volume = (package.Length * package.Width * package.Height);

                    //Package weight calculation
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (package.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != package.WeightUnitId.ToString())
                    {
                        package.Weight = package.Weight.GramToKilogramConversion();
                    }
                    totalWeight += package.Weight;

                    // Save Package Items
                    package.CargoBookingId = cargoBooking.Id;
                    var createdPackage = await _packageItemService.CreateAsync(package);

                    if (createdPackage.StatusCode == ServiceResponseStatus.Failed)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.Failed;
                    }

                    foreach (var flightSectorId in rm.FlightScheduleSectorIds)
                    {
                        var flightSector = await _flightScheduleSectorService.GetAsync(new FlightScheduleSectorQM() { Id = flightSectorId, IncludeLoadPlan = true, IncludeFlightScheduleSectorPallets= true, IncludeULDContaines= true });

                        if (flightSector == null || flightSector.LoadPlanId == null)
                        {
                            transaction.Rollback();
                            return BookingServiceResponseStatus.Failed;
                        }
                        if(flightSectors.Count < rm.FlightScheduleSectorIds.Count)
                        {
                            flightSectors.Add(flightSector);
                        }

                        // Save ULD Container Details
                        var createdULDContainer = await _uldContainerService.CreateAsync(new ULDContainerDto()
                        {
                            LoadPlanId = flightSector.LoadPlanId.Value,
                            ULDContainerType = ULDContainerType.ULD,
                            ULDId = null, //ToDo  Need to assign after ULD creation
                            Height = package.Height,
                            Length = package.Length,
                            Width = package.Width,
                        });

                        if (createdULDContainer == null || createdULDContainer.Id == Guid.Empty)
                        {
                            transaction.Rollback();
                            return BookingServiceResponseStatus.Failed;
                        }

                        var createdPackageULDContainer = await _packageItemService.PackageULDContainerCreate(new PackageULDContainerRM() { PackageItemId = createdPackage.Id, ULDContainerId = createdULDContainer.Id });

                        if (createdPackageULDContainer.StatusCode == ServiceResponseStatus.Failed)
                        {
                            transaction.Rollback();
                            return BookingServiceResponseStatus.Failed;
                        }
                    }
                }
                transaction.Commit();
                if (cargoBooking.StatusCode == ServiceResponseStatus.Success)
                {
                    var lastFlightScheduleSector = flightSectors.Last();
                    var firstFlightScheduleSector = flightSectors.First();
                    NotificationRM notificationRM = new NotificationRM();
                    notificationRM.Title = "Cargo booking made";
                    
                    notificationRM.Body = "Flight details; " + firstFlightScheduleSector.FlightNumber + " - " + firstFlightScheduleSector.OriginAirportCode + " - " + lastFlightScheduleSector.DestinationAirportCode + ",Flight Date time; "+ firstFlightScheduleSector.ScheduledDepartureDateTime.ToString("g") + ",Cargo weight ; "+totalWeight+" kg"+",Number of packages ; "+packages.Count+",Cargo cut off time ; "+ firstFlightScheduleSector.AcceptanceCutoffTime +",Please hand over your cargo to "+ firstFlightScheduleSector.OriginAirportCode + " cargo dropoff point on or before above mentioned time. ";
                    notificationRM.NotificationType = Common.Enums.NotificationType.Booking_Made;
                    await _notificationService.CreateAsync(notificationRM);
                }
            }

            return BookingServiceResponseStatus.Success;
        }

        public async Task<BookingServiceResponseStatus> StandByUpdateAsync(CargoBookingStandbyUpdateRM rm)
        {
            System.DateTime flightDate = rm.FlightDate;
            string flightNumber = rm.FlightNumber;
            Guid currentBookingId = rm.BookingId;

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                // TODO: check flight availabity                     

                var spec = new CargoBookingFlightScheduleSectorSpecification(currentBookingId);
                var currentCargoBookingFlightScheduleSector = await _unitOfWork.Repository<CargoBookingFlightScheduleSector>().GetEntityWithSpecAsync(spec);

                var specFs = new FlightScheduleSpecification(
                    new FlightScheduleStandbyQM() { FlightDate= flightDate, FlightNumber= flightNumber ,IncludeFlightScheduleSectors = true });
                var newFS = await _unitOfWork.Repository<FlightSchedule>().GetEntityWithSpecAsync(specFs);

                if (newFS == null)
                {
                    return BookingServiceResponseStatus.ValidationError;
                }

                // update CargoBooking
                var cargoBooking = currentCargoBookingFlightScheduleSector.CargoBooking;                
                cargoBooking.BookingStatus = BookingStatus.Booking_Made;
                cargoBooking.StandByStatus = StandByStatus.None;
                _unitOfWork.Repository<CargoBooking>().Update(cargoBooking);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<CargoBooking>().Detach(cargoBooking);

                foreach (var newSector in newFS.FlightScheduleSectors)
                {                
                    // check space availabity 
                    var availList = await _flightScheduleSectorService.GetFreighterAircraftAvailableSpace(newSector.Id);
                    if (availList.Count == 0)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.NoSpace;
                    }

                    // update CargoBookingFlightScheduleSector
                    currentCargoBookingFlightScheduleSector.FlightScheduleSectorId = newSector.Id;
                    _unitOfWork.Repository<CargoBookingFlightScheduleSector>().Update(currentCargoBookingFlightScheduleSector);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<CargoBookingFlightScheduleSector>().Detach(currentCargoBookingFlightScheduleSector);
                    
                    
                    foreach (var item in cargoBooking.PackageItems)
                    {
                        foreach (var cont in item.PackageULDContainers)
                        {
                            // update ULDContainer - LoadPlanId 
                            var container = cont.ULDContainer;
                            if(newSector.LoadPlanId!= null)
                            {
                                container.LoadPlanId = newSector.LoadPlanId.Value;
                                _unitOfWork.Repository<ULDContainer>().Update(container);
                                await _unitOfWork.SaveChangesAsync();
                                _unitOfWork.Repository<ULDContainer>().Detach(container);
                            }                            
                        }
                    }
                }                            
                transaction.Commit();
                NotificationRM notificationRM = new NotificationRM();
                notificationRM.NotificationType = Common.Enums.NotificationType.Cargo_AssignedTo_New_Flight;
                notificationRM.UserId = cargoBooking.CreatedBy;
                notificationRM.Title = "Cargo re-assignement for AWB : "+ cargoBooking.AWBInformation.AwbTrackingNumber;
                notificationRM.Body = "Your offloaded cargo with AWB "+ cargoBooking.AWBInformation.AwbTrackingNumber + " has reassigned to the fligt "+rm.FlightNumber+" on "+ rm.FlightDate.ToString("g")+".";
                await _notificationService.CreateAsync(notificationRM);
            }
             

            return BookingServiceResponseStatus.Success;
        }

        public async Task<ServiceResponseCreateStatus> AssginCargoToULDAsync(ULDContainerCargoPositionRM uLDContainerCargoPosition)
        {
            var response = new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success };

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                foreach(var uldContainerId in uLDContainerCargoPosition.ULDContainerIds)
                {
                    var spec = new ULDContainerCargoPositionSpecification(new ULDCOntainerCargoPositionQM()
                    {
                        ULDContainerId = uldContainerId,
                        IsIncludeULDContainer = true,
                        IsIncludePackageItem = true,
                    });
                    var entity = await _unitOfWork.Repository<ULDContainerCargoPosition>().GetEntityWithSpecAsync(spec);
                    bool needToCreate = true;
                    if (entity != null)
                    {
                        if (uLDContainerCargoPosition.CargoPositionId == entity.CargoPositionId)
                        {
                            // same record
                            needToCreate = false;
                        }
                        else
                        {
                            // remove exisiting record
                            _unitOfWork.Repository<ULDContainerCargoPosition>().Delete(entity);
                            await _unitOfWork.SaveChangesAsync();
                            _unitOfWork.Repository<ULDContainerCargoPosition>().Detach(entity);
                            // reset existing volume
                            await UpdateCurrentWeightAsyncs(entity.CargoPositionId, entity.ULDContainer.PackageULDContainers.Where(x => x.ULDContainerId == entity.ULDContainer.Id).Sum(x => x.PackageItem.Weight) * -1);
                            await UpdateCurrentVolumeAsyncs(entity.CargoPositionId, (entity.ULDContainer.Length * entity.ULDContainer.Width * entity.ULDContainer.Height) * -1);
                            _unitOfWork.Repository<ULDContainer>().Detach(entity.ULDContainer);
                            needToCreate = true;
                        }
                    }

                    if (needToCreate)
                    {
                        var position = await _unitOfWork.Repository<CargoPosition>().GetEntityWithSpecAsync(
                            new CargoPositionSpecification(new CargoPositionQM() { Id = uLDContainerCargoPosition.CargoPositionId }));
                        _unitOfWork.Repository<CargoPosition>().Detach(position);

                        var containter = await _unitOfWork.Repository<ULDContainer>().GetEntityWithSpecAsync(
                            new ULDContainerSpecification(new ULDContainerQM() { Id = uldContainerId }));
                        // _unitOfWork.Repository<ULDContainer>().Detach(containter);

                        var uld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(new ULDSpecification(new ULDQM() { PositionId = uLDContainerCargoPosition.CargoPositionId }));

                        string exeedType = "";
                        double uldPackageWeght = containter.PackageULDContainers.Where(x => x.ULDContainerId == containter.Id).Sum(x => x.PackageItem.Weight) + uld.ULDMetaData.Weight;

                        if (position.MaxWeight < (uldPackageWeght + position.CurrentWeight)) exeedType = "pallete";
                        if (position.ZoneArea.MaxWeight < (uldPackageWeght + position.ZoneArea.CurrentWeight)) exeedType = "zone area";
                        if (position.ZoneArea.AircraftCabin.MaxWeight < (uldPackageWeght + position.ZoneArea.AircraftCabin.CurrentWeight)) exeedType = "aircraft cabin";
                        if (position.ZoneArea.AircraftCabin.AircraftDeck.MaxWeight < (uldPackageWeght + position.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight)) exeedType = "aircraft deck";

                        if (exeedType != "")
                        {
                            transaction.Rollback();
                            response.StatusCode = ServiceResponseStatus.ValidationError;
                            response.Message = string.Format("Max {0} weight is exceeded.", exeedType); ;
                            return response;
                        }

                        if (position.MaxVolume < (position.CurrentVolume + (containter.Width + containter.Height + containter.Length)))
                        {
                            transaction.Rollback();
                            response.StatusCode = ServiceResponseStatus.ValidationError;
                            response.Message = "Max pallete volume is exceeded.";
                            return response;
                        }

                        try
                        {
                            containter.ULDId = uld.Id;
                            _unitOfWork.Repository<ULDContainer>().Update(containter);
                            await _unitOfWork.SaveChangesAsync();
                            _unitOfWork.Repository<ULDContainer>().Detach(containter);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw;
                        }

                        await _uLDContainerCargoPositionService.CreateAsync(new ULDContainerCargoPositionDto() { CargoPositionId = uLDContainerCargoPosition.CargoPositionId , ULDContainerId=uldContainerId});
                    }
                }
                await UpdateCurrentWeightAsyncs(uLDContainerCargoPosition.CargoPositionId, uLDContainerCargoPosition.Weight);
                await UpdateCurrentVolumeAsyncs(uLDContainerCargoPosition.CargoPositionId, uLDContainerCargoPosition.Volume);
                transaction.Commit();
            }
            return response;
        }

        async Task UpdateCurrentWeightAsyncs(Guid positionId, double weight)
        {
            var position = await _unitOfWork.Repository<CargoPosition>().GetEntityWithSpecAsync(new CargoPositionSpecification(new CargoPositionQM() { Id = positionId }));
            position.CurrentWeight += weight;
            position.ZoneArea.CurrentWeight += weight;
            position.ZoneArea.AircraftCabin.CurrentWeight += weight;
            position.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight += weight;
            _unitOfWork.Repository<CargoPosition>().Update(position);
            _unitOfWork.Repository<ZoneArea>().Update(position.ZoneArea);
            _unitOfWork.Repository<AircraftCabin>().Update(position.ZoneArea.AircraftCabin);
            _unitOfWork.Repository<AircraftDeck>().Update(position.ZoneArea.AircraftCabin.AircraftDeck);

            await _unitOfWork.SaveChangesAsync();

            _unitOfWork.Repository<CargoPosition>().Detach(position);
            _unitOfWork.Repository<ZoneArea>().Detach(position.ZoneArea);
            _unitOfWork.Repository<AircraftCabin>().Detach(position.ZoneArea.AircraftCabin);
            _unitOfWork.Repository<AircraftDeck>().Detach(position.ZoneArea.AircraftCabin.AircraftDeck);

        }

        async Task UpdateCurrentVolumeAsyncs(Guid positionId, double volume)
        {
            var position = await _unitOfWork.Repository<CargoPosition>().GetEntityWithSpecAsync(new CargoPositionSpecification(new CargoPositionQM() { Id = positionId }));
            position.CurrentVolume += volume;

            _unitOfWork.Repository<CargoPosition>().Update(position);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<CargoPosition>().Detach(position);
        }

        public async Task<CargoBookingDetailVM> GetBookingAsync(CargoBookingDetailQM query)
        {
            return await _uldCargoBookingService.GetAsync(query);
        }

        public async Task<BookingServiceResponseStatus> UpdateStatusAsync(CargoBookingUpdateRM rm)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {

                // Update Cargo Booking Details
                var response = await _uldCargoBookingService.UpdateStatusAsync(rm);
                if (response.StatusCode == ServiceResponseStatus.Failed)
                {
                    transaction.Rollback();
                    return BookingServiceResponseStatus.Failed;
                }

                transaction.Commit();
            }

            return BookingServiceResponseStatus.Success;
        }

        public async Task<IReadOnlyList<ULDCargoBookingListVM>> GetULDBookingListAsync(CargoPositionULDContainerListQM query)
        {
            var spec = new ULDContainerCargoPositionSpecification(new CargoPositionULDContainerListQM()
            {
                CargoPositionId = query.CargoPositionId,
                IsIncludePackageItem = true,
            });
            var entities = await _unitOfWork.Repository<ULDContainerCargoPosition>().GetListWithSpecAsync(spec);
            List<ULDCargoBookingListVM> list = new List<ULDCargoBookingListVM>();
            List<CargoBooking> bookingList = new List<CargoBooking>();

            if (entities != null)
            {
                foreach (var entity in entities)
                {
                    foreach (var packageULDContainer in entity.ULDContainer.PackageULDContainers)
                    {
                        var booking = packageULDContainer.PackageItem.CargoBooking;
                        var cargoBooking = await _unitOfWork.Repository<CargoBooking>().GetEntityWithSpecAsync(new CargoBookingSpecification(new CargoBookingQM() { Id = booking.Id, IsIncludePackageDetail = true, IsIncludeAWBDetail=true }));
                        if (!bookingList.Exists(x => x.Id == cargoBooking.Id))
                            bookingList.Add(cargoBooking);
                    }
                }

                if (bookingList != null)
                {
                    foreach (var booking in bookingList)
                    {
                        var agent = await _cargoAgentService.GetAsync(new Models.Queries.CargoAgentQMs.CargoAgentQM() { AppUserId = booking.CreatedBy });
                        ULDCargoBookingListVM vm = new ULDCargoBookingListVM();
                        vm.BookingNumber = booking.BookingNumber;
                        vm.AWBNumber = booking.AWBInformation == null ? "-" : booking.AWBInformation.AwbTrackingNumber.ToString();
                        vm.BookingAgent = agent != null ? agent.AgentName : string.Empty;
                        vm.NumberOfBoxes = booking.PackageItems == null ? 0 : booking.PackageItems.Count();

                        List<PackageItem> packages = new List<PackageItem>();
                        if (booking.PackageItems != null)
                        {
                            foreach(var packageItem in booking.PackageItems)
                            {
                                foreach(var uLDContainerCargoPosition in entities)
                                {
                                    foreach (var packageULDContainers in packageItem.PackageULDContainers)
                                    {
                                        if (uLDContainerCargoPosition.ULDContainerId == packageULDContainers.ULDContainerId && !packages.Exists(x => x.Id == packageItem.Id))
                                        {
                                            packages.Add(packageItem);
                                        }
                                    }

                                }
                            }
                        }

                        vm.NumberOfAssignedBoxes = packages.Count();
                        vm.TotalWeight = packages == null ? 0 : packages.Sum(x => x.Weight);
                        vm.TotalVolume = packages == null ? 0 : packages.Sum(x =>
                        (_baseUnitConverter.VolumeCalculatorAsync(x.Height, (Guid)x.VolumeUnitId).Result *
                         _baseUnitConverter.VolumeCalculatorAsync(x.Width, (Guid)x.VolumeUnitId).Result *
                         _baseUnitConverter.VolumeCalculatorAsync(x.Length, (Guid)x.VolumeUnitId).Result
                        ));
                        list.Add(vm);
                    }
                }
            }
            return list;
        }

        public async Task<ServiceResponseCreateStatus> AddPalleteToFlightAsync(FlightScheduleSectorPalletCreateRM rm)
        {
            return await _flightScheduleSectorPalletService.CreateAsync(rm);
        }

        public async Task<List<ULDFilteredListVM>> GetPalleteFromFlights(FlightSheduleSectorPalletGetList filter)
        {
            var list =  await _flightScheduleSectorPalletService.GetPalleteListAsync(filter);
            return list;
        }

        public async Task<ServiceResponseStatus> SaveBookingAssigmentAsync(BookingAssignmentRM bookingAssignment)
        {
            var spec = new PackageULDContainerSpecification(
                new PackageULDContainerListQM() 
                { 
                    PackageItemId = bookingAssignment.PackageId 
                });
            var packageULDContainers = await _unitOfWork.Repository<PackageULDContainer>().GetListWithSpecAsync(spec);

            return await _uldContainerService.UpdateUldIdAsync(
                new ULDContainerUpdateRM() 
                { 
                    ULDId = bookingAssignment.uldId, 
                    Id = packageULDContainers.FirstOrDefault().ULDContainerId 
                });
        }

        
        public async Task<ServiceResponseStatus> RemoveBookedAssigmentAsync(BookingAssignmentRM bookingAssignment)
        {
            var spec = new PackageULDContainerSpecification(
                new PackageULDContainerListQM() 
                { 
                    PackageItemId = bookingAssignment.PackageId 
                });
            var packageULDContainers = await _unitOfWork.Repository<PackageULDContainer>().GetListWithSpecAsync(spec);

            return await _uldContainerService.RemoveUldIdAsync(
                new ULDContainerUpdateRM() 
                { 
                    ULDId = bookingAssignment.uldId, 
                    Id = packageULDContainers.FirstOrDefault().ULDContainerId 
                });
        }
        
        public async Task<IEnumerable<FlightScheduleSectorUldPositionVM>> GetFlightScheduleSectorWithULDPositionCountAsync(FlightScheduleSectorULDPositionCountQM query)
        {
            return await _flightScheduleSectorService.GetFlightScheduleSectorWithULDPositionCountAsync(query);
        }

        public async Task<ServiceResponseStatus> CreateRemovePalleteListAsync(FlightScheduleSectorPalletCreateListRM request)
        {
            return await _flightScheduleSectorPalletService.CreateRemovePalletListAsync(request);
        }

        public async Task<ServiceResponseStatus> DeleteAssignedPalletFromSchedule(FlightScheduleSectorPalletCreateRM query)
        {
            var entity = await _flightScheduleSectorPalletService.GetAssignedULDSectorPallet(query);

            if (entity == null)
            {
                return ServiceResponseStatus.ValidationError;
            }

            var result = await _flightScheduleSectorPalletService.DeleteAsync(entity: entity);
            if(!result)
            {
                return ServiceResponseStatus.ValidationError;
            }
            return ServiceResponseStatus.Success;

        }
    }
}
