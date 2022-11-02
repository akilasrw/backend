using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.Queries.CargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
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
        private readonly IULDCargoPositionService _uLDCargoPositionService;
        private readonly IAircraftService _aircraftService;
        private readonly IBaseUnitConverter _baseUnitConverter;
        private readonly IULDContainerCargoPositionService _ULDContainerCargoPositionService;
        public PalletService(IUnitOfWork unitOfWork, 
            IMapper mapper,
            IULDMetaDataService uLDMetaDataService, 
            IULDService uLDService,
            IULDContainerCargoPositionService uLDContainerCargoPositionService,
            IULDContainerService uLDContainerService,
            IAircraftService aircraftService,
            IBaseUnitConverter baseUnitConverter, 
            IConfiguration configuration,
            IULDCargoPositionService uLDCargoPositionService)
            :base(unitOfWork, mapper)
        {
            _uLDMetaDataService = uLDMetaDataService;
            _uLDService = uLDService;
            _uLDContainerService = uLDContainerService;
            _configuration = configuration;
            _uLDCargoPositionService = uLDCargoPositionService;
            _ULDContainerCargoPositionService = uLDContainerCargoPositionService;
            _aircraftService = aircraftService;
            _baseUnitConverter = baseUnitConverter;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(PalletCreateRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    //Pallet volume conversion
                    dto.Length =await _baseUnitConverter.VolumeCalculatorAsync(dto.Length, dto.VolumeUnitId);
                    dto.Height =await _baseUnitConverter.VolumeCalculatorAsync(dto.Height, dto.VolumeUnitId);
                    dto.Width =await _baseUnitConverter.VolumeCalculatorAsync(dto.Width, dto.VolumeUnitId);

                    //Pallet weight conversion
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (dto.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != dto.WeightUnitId.ToString())
                    {
                        dto.Weight = dto.Weight.GramToKilogramConversion();
                    }

                    // Save ULD meta data
                    var uldMetaDeta = await _uLDMetaDataService.CreateAsync(new ULDMetaDataDto()
                    {
                        Height = dto.Height,
                        Length = dto.Length,
                        Width = dto.Width,
                        Weight = dto.Weight,
                        Sequence = dto.Sequence
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
                        ULDMetaDataId = uldMetaDeta.Id,
                    });


                    if (uld == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }
                    else
                    {
                        var position = await _uLDCargoPositionService.CreateAsync(new ULDCargoPositionDto() { CargoPositionId = dto.PositionId, ULDId = uld.Id });

                        if (position == null)
                        {
                            transaction.Rollback();
                            response.StatusCode = ServiceResponseStatus.Failed;
                            return response;
                        }
                    }                    

                    //var positionContainers = await _ULDContainerCargoPositionService.GetListAsync(new ULDCOntainerCargoPositionQM()
                    //{
                    //    IsIncludeULDContainer = true,
                    //    CargoPositionId = cargoPosition.Id
                    //});

                    // assgined boxes to Pallet. 
                    //if (positionContainers != null && positionContainers.Count > 0)
                    //{
                    //    foreach (var positionContainer in positionContainers)
                    //    {
                    //        await _uLDContainerService.UpdateULDIdAsync(new ULDContainerUpdateRM()
                    //        {
                    //            Id = positionContainer.ULDContainer.Id,
                    //            ULDId = uld.Id,
                    //        });

                    //    }
                    //}
                    //else
                    //{
                    //    transaction.Rollback();
                    //    response.StatusCode = ServiceResponseStatus.ValidationError;
                    //    return response;
                    //}

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

            if (aircraft.ConfigurationType != AircraftConfigType.Freighter)
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
                palletPosition.Position = int.Parse(cargoPosition.Name);

                var uld = await _uLDService.GetAsync(new ULDQM() { PositionId = cargoPosition.Id });
                
                if (uld != null && uld.ULDMetaData != null)
                {
                    palletPosition.IsPalletAssigned = true;
                    palletPosition.Length = uld.ULDMetaData.Length;
                    palletPosition.Width = uld.ULDMetaData.Width;
                    palletPosition.Height = uld.ULDMetaData.Height;
                    palletPosition.Weight = uld.ULDMetaData.Weight;
                    palletPosition.SerialNumber = uld.SerialNumber;
                }
                palletPositions.Add(palletPosition);
            }
            return palletPositions.OrderBy(x=>x.Position).ToList();
        }
    }
}
