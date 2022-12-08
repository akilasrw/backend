﻿using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDContainerCargoPositionVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDCargoBookingManagerService : BaseService, IULDCargoBookingManagerService
    {
        private readonly IULDCargoBookingService _uldCargoBookingService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly IULDContainerCargoPositionService _uLDContainerCargoPositionService;
        private readonly IConfiguration _configuration;
        private readonly IULDContainerService _uldContainerService;
        private readonly IPackageItemService _packageItemService;
        private readonly IAWBService _AWBService;
        private readonly IBaseUnitConverter _baseUnitConverter;
        private readonly IAssignCargoToULDService _assignCargoToULDService;
        private readonly ICargoAgentService _cargoAgentService;

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
        IBaseUnitConverter baseUnitConverter) :
            base(unitOfWork, mapper)
        {
            _uldCargoBookingService = uldCargoBookingService;
            _flightScheduleSectorService = flightScheduleSectorService;
            _uLDContainerCargoPositionService = uLDContainerCargoPositionService;
            _configuration = configuration;
            _uldContainerService = uldcontainerService;
            _packageItemService = packageItemService;
            _AWBService = AWBService;
            _baseUnitConverter = baseUnitConverter;
            _assignCargoToULDService = assignCargoToULDService;
            _cargoAgentService = cargoAgentService;
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

                //Save AWB Details
                if (rm.AWBDetail != null)
                {
                    rm.AWBDetail.CargoBookingId = response.Id;
                    var awbResponse = await _AWBService.CreateAsync(rm.AWBDetail);

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
                    for(int i= 0; i < package.Pieces; i++)
                    {
                        var clonePackage = new PackageItemCreateRM();
                        clonePackage = package;
                        clonedPackages.Add(clonePackage);
                    }
                }

                foreach (var package in clonedPackages)
                {

                    //Package volume calculation
                    package.Length= await _baseUnitConverter.VolumeCalculatorAsync(package.Length, package.VolumeUnitId);
                    package.Width= await _baseUnitConverter.VolumeCalculatorAsync(package.Width, package.VolumeUnitId);
                    package.Height= await _baseUnitConverter.VolumeCalculatorAsync(package.Height, package.VolumeUnitId);
                    package.Volume = (package.Length * package.Width * package.Height);

                    //Package weight calculation
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (package.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != package.WeightUnitId.ToString())
                    {
                        package.Weight = package.Weight.GramToKilogramConversion();
                    }

                    // Save ULD Container Details
                    var uldContainer = await _uldContainerService.CreateAsync(new ULDContainerDto()
                    {
                        LoadPlanId = flightSector.LoadPlanId.Value,
                        ULDContainerType = ULDContainerType.ULD,
                        ULDId = null, //ToDo  Need to assign after ULD creation
                        Height = package.Height,
                        Length = package.Length,
                        Width = package.Width,
                    });

                    if (uldContainer == null)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.Failed;
                    }

                    // Save Package Items
                    package.CargoBookingId = response.Id;
                    package.ULDContainerId = uldContainer.Id;
                    var createdPackage = await _packageItemService.CreateAsync(package);

                    if (createdPackage.StatusCode == ServiceResponseStatus.Failed)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.Failed;
                    }
                }
                transaction.Commit();
            }

            return BookingServiceResponseStatus.Success;
        }

        public async Task<ServiceResponseCreateStatus> AssginCargoToULDAsync(ULDContainerCargoPositionDto uLDContainerCargoPosition)
        {
            var response = new ServiceResponseCreateStatus() { StatusCode = ServiceResponseStatus.Success };

            var spec = new ULDContainerCargoPositionSpecification(new ULDCOntainerCargoPositionQM()
            {
                ULDContainerId = uLDContainerCargoPosition.ULDContainerId,
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
                    await UpdateCurrentWeightAsyncs(entity.CargoPositionId, entity.ULDContainer.PackageItems.Sum(x => x.Weight) * -1);
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
                    new ULDContainerSpecification(new ULDContainerQM() { Id = uLDContainerCargoPosition.ULDContainerId }));
                // _unitOfWork.Repository<ULDContainer>().Detach(containter);

                var uld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(new ULDSpecification(new ULDQM() { PositionId = uLDContainerCargoPosition.CargoPositionId }));

                string exeedType = "";
                double uldPackageWeght = containter.PackageItems.Sum(x => x.Weight) + uld.ULDMetaData.Weight;

                if (position.MaxWeight < (uldPackageWeght + position.CurrentWeight)) exeedType = "pallete";
                if (position.ZoneArea.MaxWeight < (uldPackageWeght + position.ZoneArea.CurrentWeight)) exeedType = "zone area";
                if (position.ZoneArea.AircraftCabin.MaxWeight < (uldPackageWeght + position.ZoneArea.AircraftCabin.CurrentWeight)) exeedType = "aircraft cabin";
                if (position.ZoneArea.AircraftCabin.AircraftDeck.MaxWeight < (uldPackageWeght + position.ZoneArea.AircraftCabin.AircraftDeck.CurrentWeight)) exeedType = "aircraft deck";

                if (exeedType != "")
                {
                    response.StatusCode = ServiceResponseStatus.ValidationError;
                    response.Message = string.Format("Max {0} weight is exceeded.", exeedType); ;
                    return response;
                }

                if (position.MaxVolume < (position.CurrentVolume + (containter.Width + containter.Height + containter.Length)))
                {
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
                    throw;
                }

                await _uLDContainerCargoPositionService.CreateAsync(uLDContainerCargoPosition);
                await UpdateCurrentWeightAsyncs(uLDContainerCargoPosition.CargoPositionId, uLDContainerCargoPosition.Weight);
                await UpdateCurrentVolumeAsyncs(uLDContainerCargoPosition.CargoPositionId, uLDContainerCargoPosition.Volume);
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

        public async Task<BookingServiceResponseStatus> UpdateAsync(CargoBookingUpdateRM rm)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
     
                // Update Cargo Booking Details
                var response = await _uldCargoBookingService.UpdateAsync(rm);
                if (response.StatusCode == ServiceResponseStatus.Failed)
                {
                    transaction.Rollback();
                    return BookingServiceResponseStatus.Failed;
                }

                transaction.Commit();
            }

            return BookingServiceResponseStatus.Success;
        }

        public async Task<IReadOnlyList<CargoBookingListVM>> GetULDBookingListAsync(CargoPositionULDContainerListQM query)
        {
            var spec = new ULDContainerCargoPositionSpecification(new CargoPositionULDContainerListQM()
            {
                CargoPositionId = query.CargoPositionId,
                IsIncludePackageItem = true,
            });
            var entities = await _unitOfWork.Repository<ULDContainerCargoPosition>().GetListWithSpecAsync(spec);
            List<CargoBookingListVM> list = new List<CargoBookingListVM>();

            if (entities != null)
            {
                foreach (var entity in entities)
                {
                    foreach (var package in entity.ULDContainer.PackageItems)
                    {
                        var booking = package.CargoBooking;
                        var agent = await _cargoAgentService.GetAsync(new Models.Queries.CargoAgentQMs.CargoAgentQM() { AppUserId = booking.CreatedBy });
                        CargoBookingListVM vm = new CargoBookingListVM();
                        vm.BookingNumber = booking.BookingNumber;
                        vm.AWBNumber = booking.AWBInformation == null ? "-" : booking.AWBInformation.AwbTrackingNumber.ToString();
                        vm.BookingAgent = agent != null ? agent.AgentName : string.Empty;
                        vm.BookingDate = booking.BookingDate;
                        vm.BookingStatus = booking.BookingStatus;
                        vm.NumberOfBoxes = booking.PackageItems == null ? 0 : booking.PackageItems.Count();
                        vm.TotalWeight = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x => x.Weight);
                        vm.TotalVolume = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x =>
                        (_baseUnitConverter.VolumeCalculatorAsync(x.Height, x.VolumeUnitId).Result *
                         _baseUnitConverter.VolumeCalculatorAsync(x.Width, x.VolumeUnitId).Result *
                         _baseUnitConverter.VolumeCalculatorAsync(x.Length, x.VolumeUnitId).Result
                        ));
                        list.Add(vm);
                    }

                }
                

            }
/*
            var spec = new FlightScheduleSectorSpecification(query);
            var fSectorList = await _unitOfWork.Repository<FlightScheduleSector>().GetListWithSpecAsync(spec);
            List<CargoBookingListVM> list = new List<CargoBookingListVM>();
            foreach (var f in fSectorList)
            {
                foreach (var booking in f.CargoBookings)
                {
                    var agent = await _cargoAgentService.GetAsync(new Models.Queries.CargoAgentQMs.CargoAgentQM() { AppUserId = booking.CreatedBy });
                    CargoBookingListVM vm = new CargoBookingListVM();
                    vm.BookingNumber = booking.BookingNumber;
                    vm.AWBNumber = booking.AWBInformation == null ? "-" : booking.AWBInformation.AwbTrackingNumber.ToString();
                    vm.BookingAgent = agent != null ? agent.AgentName : string.Empty;
                    vm.BookingDate = booking.BookingDate;
                    vm.BookingStatus = booking.BookingStatus;
                    vm.NumberOfBoxes = booking.PackageItems == null ? 0 : booking.PackageItems.Count();
                    vm.TotalWeight = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x => x.Weight);
                    vm.TotalVolume = booking.PackageItems == null ? 0 : booking.PackageItems.Sum(x =>
                    (_baseUnitConverter.VolumeCalculatorAsync(x.Height, x.VolumeUnitId).Result *
                     _baseUnitConverter.VolumeCalculatorAsync(x.Width, x.VolumeUnitId).Result *
                     _baseUnitConverter.VolumeCalculatorAsync(x.Length, x.VolumeUnitId).Result
                    ));
                    list.Add(vm);
                }
            }*/
            return list;
        }

    }
}
