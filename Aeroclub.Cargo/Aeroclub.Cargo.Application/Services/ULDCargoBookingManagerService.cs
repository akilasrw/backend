using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoBookingRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDCargoBookingManagerService : BaseService, IULDCargoBookingManagerService
    {
        private readonly IULDCargoBookingService _uldCargoBookingService;
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;
        private readonly IConfiguration _configuration;
        private readonly IULDCargoPositionService _uldcgoPositionService;
        private readonly IULDContainerService _uldContainerService;
        private readonly IPackageItemService _packageItemService;
        private readonly IAWBService _AWBService;
        private readonly IULDContainerCargoPositionService _uLDContainerCargoPositionService;

        public ULDCargoBookingManagerService(IUnitOfWork unitOfWork, 
            IMapper mapper, 
            IULDCargoBookingService uldCargoBookingService, 
            IFlightScheduleSectorService flightScheduleSectorService,
            IULDCargoPositionService uldcgoPositionService,
            IULDContainerService uldcontainerService,
            IPackageItemService packageItemService,
            IAWBService AWBService,
            IConfiguration configuration,
            IULDContainerCargoPositionService uLDContainerCargoPositionService) :
            base(unitOfWork, mapper)
        {
            _uldCargoBookingService = uldCargoBookingService;
            _flightScheduleSectorService = flightScheduleSectorService;
            _configuration = configuration;
            _uldcgoPositionService = uldcgoPositionService;
            _uldContainerService = uldcontainerService;
            _packageItemService = packageItemService;
            _AWBService = AWBService;
            _uLDContainerCargoPositionService = uLDContainerCargoPositionService;

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
                    var cmVolumeUnitId = _configuration["BaseUnit:BaseVolumeUnitId"];
                    if(package.VolumeUnitId != Guid.Empty && cmVolumeUnitId.ToLower() != package.VolumeUnitId.ToString())
                    {
                        var inchVolumeUnitId = _configuration["VolumeUnit:InchVolumeUnitId"];
                        var meterVolumeUnitId = _configuration["VolumeUnit:MeterVolumeUnitId"];

                        if(meterVolumeUnitId.ToLower() == package.VolumeUnitId.ToString())
                        {
                            package.Length = package.Length.MeterToCmConversion();
                            package.Width = package.Width.MeterToCmConversion();
                            package.Height = package.Height.MeterToCmConversion();
                        }

                        if (inchVolumeUnitId.ToLower() == package.VolumeUnitId.ToString())
                        {
                            package.Length = package.Length.InchToCmConversion();
                            package.Width = package.Width.InchToCmConversion();
                            package.Height = package.Height.InchToCmConversion();
                        }
                    }
                    package.Volume = (package.Length * package.Width * package.Height);

                    //Package weight calculation
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (package.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != package.WeightUnitId.ToString())
                    {
                        package.Weight = package.Weight.GramToKilogramConversion();
                    }

                    CargoPosition matchedCargoPosition = null;
                    if (package.PackageContainerType == PackageContainerType.OnFloor)
                        matchedCargoPosition = await _uldcgoPositionService.GetMatchingCargoPositionAsync(package, flightSector.AircraftLayoutId.Value, (CargoPositionType)package.PackageContainerType);

                    if (matchedCargoPosition == null)
                    {
                        transaction.Rollback();
                        return BookingServiceResponseStatus.NoSpace;
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

                    // Update ULDContainer Cargo Position
                    await _uLDContainerCargoPositionService.CreateAsync(new ULDContainerCargoPositionDto()
                    {
                        CargoPositionId = matchedCargoPosition.Id,
                        ULDContainerId = uldContainer.Id
                    });

                    // Update Current Weights
                    await UpdateCurrentWeightAsyncs(matchedCargoPosition.Id,package.Weight);

                    // Update Current Volume
                    await UpdateCurrentVolumeAsyncs(matchedCargoPosition.Id, package.Volume);

                }
                transaction.Commit();
            }

            return BookingServiceResponseStatus.Success;
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
    }
}
