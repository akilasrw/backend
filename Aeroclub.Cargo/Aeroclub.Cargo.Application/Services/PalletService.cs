using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PalletManagementRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDContainer;
using Aeroclub.Cargo.Application.Models.ViewModels.PalletVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class PalletService : BaseService, IPalletService
    {
        private readonly IULDMetaDataService _uLDMetaDataService;
        private readonly IULDService _uLDService;
        private readonly IULDContainerService _uLDContainerService;
        private readonly IConfiguration _configuration;
        private readonly IAircraftService _aircraftService;
        private readonly IULDContainerCargoPositionService _ULDContainerCargoPositionService;
        public PalletService(IUnitOfWork unitOfWork, 
            IMapper mapper,
            IULDMetaDataService uLDMetaDataService, 
            IULDService uLDService,
            IULDContainerCargoPositionService uLDContainerCargoPositionService,
            IULDContainerService uLDContainerService,
            IAircraftService aircraftService, 
            IConfiguration configuration)
            :base(unitOfWork, mapper)
        {
            _uLDMetaDataService = uLDMetaDataService;
            _uLDService = uLDService;
            _uLDContainerService = uLDContainerService;
            _configuration = configuration;
            _ULDContainerCargoPositionService = uLDContainerCargoPositionService;
            _aircraftService = aircraftService;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(PalletCreateRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    //Pallet volume conversion
                    var cmVolumeUnitId = _configuration["BaseUnit:BaseVolumeUnitId"];
                    if (dto.VolumeUnitId != Guid.Empty && cmVolumeUnitId.ToLower() != dto.VolumeUnitId.ToString())
                    {
                        var inchVolumeUnitId = _configuration["VolumeUnit:InchVolumeUnitId"];
                        var meterVolumeUnitId = _configuration["VolumeUnit:MeterVolumeUnitId"];

                        if (meterVolumeUnitId.ToLower() == dto.VolumeUnitId.ToString())
                        {
                            dto.Length = dto.Length.MeterToCmConversion();
                            dto.Width = dto.Width.MeterToCmConversion();
                            dto.Height = dto.Height.MeterToCmConversion();
                        }

                        if (inchVolumeUnitId.ToLower() == dto.VolumeUnitId.ToString())
                        {
                            dto.Length = dto.Length.InchToCmConversion();
                            dto.Width = dto.Width.InchToCmConversion();
                            dto.Height = dto.Height.InchToCmConversion();
                        }
                    }

                    //Pallet weight conversion
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (dto.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != dto.WeightUnitId.ToString())
                    {
                        dto.Weight = dto.Weight.GramToKilogramConversion();
                    }

                    var cargoPosition = await _unitOfWork.Repository<CargoPosition>().GetByIdAsync(id: dto.PositionId);

                    if (cargoPosition == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    // Save ULD meta data
                    var uldMetaDeta = await _uLDMetaDataService.CreateAsync(new ULDMetaDataDto()
                    {
                        Height = dto.Height,
                        Length = dto.Length,
                        Width = dto.Width,
                        Weight = dto.Weight,
                    });

                    if (uldMetaDeta == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    // Save ULD
                    var uld = await _uLDService.CreateAsync(new ULDDto()
                    {
                        ULDType = ULDType.None,
                        SerialNumber = dto.SerialNumber,
                        ULDMetaDataId = uldMetaDeta.Id
                    });

                    if (uld == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }


                    var positionContainers = await _ULDContainerCargoPositionService.GetListAsync(new ULDCOntainerCargoPositionQM()
                    {
                        IsIncludeULDContainer = true,
                        CargoPositionId = cargoPosition.Id
                    });

                    if (positionContainers != null && positionContainers.Count > 0)
                    {
                        foreach (var positionContainer in positionContainers)
                        {
                            await _uLDContainerService.UpdateULDIdAsync(new ULDContainerUpdateRM()
                            {
                                Id = positionContainer.ULDContainer.Id,
                                ULDId = uld.Id,
                            });

                        }
                    }
                    else
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                        return response;
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            response.StatusCode = ServiceResponseStatus.Success;

            return response;

        }

        public async Task<IReadOnlyList<PalletDetailVM>> GetFilteredPositionListAsync(PalletPositionSearchQM query)
        {
            var palletPositions = new List<PalletDetailVM>();

            var aircraft = await _aircraftService.GetAsync(new AircraftQM() { RegNo = query.AircraftNumber });

            if (aircraft == null)
                return palletPositions;

            var spec = new FlightScheduleSectorSpecification(new FlightScheduleSectorSearchQM()
            {
                FlightDate = query.FlightDate,
                FlightNumber = query.FlightNumber,
                AircraftId = aircraft.Id,
            });
            var flightScheduleSector = await _unitOfWork.Repository<FlightScheduleSector>().GetEntityWithSpecAsync(spec);
            if (flightScheduleSector == null)
                return palletPositions;

            var cargoPositionSpec = new CargoPositionSpecification(new CargoPositionListQM
            { AircraftLayoutId = flightScheduleSector.LoadPlan.AircraftLayoutId });

            var cargoPositions = await _unitOfWork.Repository<CargoPosition>().GetListWithSpecAsync(cargoPositionSpec);

            foreach (var cargoPosition in cargoPositions)
            {
                var palletPosition = new PalletDetailVM();
                palletPosition.CargoPositionId = cargoPosition.Id;

                var positionContainers = await _ULDContainerCargoPositionService.GetListAsync(new ULDCOntainerCargoPositionQM()
                {
                    IsIncludeULDContainer = true,
                    CargoPositionId = cargoPosition.Id
                });

                if(positionContainers != null && positionContainers.Count >0)
                {
                    var firstContainer = positionContainers.First();
                    if(firstContainer.ULDContainer.ULD != null)
                    {
                        palletPosition.IsPalletAssigned = true;
                        palletPosition.Length = firstContainer.ULDContainer.ULD.ULDMetaData.Length;
                        palletPosition.Width = firstContainer.ULDContainer.ULD.ULDMetaData.Width;
                        palletPosition.Height = firstContainer.ULDContainer.ULD.ULDMetaData.Height;
                        palletPosition.Weight = firstContainer.ULDContainer.ULD.ULDMetaData.Weight;
                        palletPosition.SerialNumber = firstContainer.ULDContainer.ULD.SerialNumber;
                    }
                }

                palletPositions.Add(palletPosition);
            }
            return palletPositions;
        }
    }
}
