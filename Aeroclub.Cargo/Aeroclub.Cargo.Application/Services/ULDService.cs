using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.ULDQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDByFlightScheduleRM;
using Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Common.Extentions;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Application.Services
{
    public class ULDService :BaseService, IULDService
    {
        private readonly IULDMetaDataService _uLDMetaDataService;
        private readonly IBaseUnitConverter _baseUnitConverter;
        private readonly IConfiguration _configuration;


        public ULDService(IMapper mapper, IUnitOfWork unitOfWork, IULDMetaDataService uLDMetaDataService,IBaseUnitConverter baseUnitConverter, IConfiguration configuration) :
            base(unitOfWork,mapper)
        {
            _uLDMetaDataService = uLDMetaDataService;
            _baseUnitConverter = baseUnitConverter;
            _configuration = configuration;
        }

        public async Task<ServiceResponseCreateStatus> CreateULDAsync(ULDDto ULDDto)
        {
            var uld = _mapper.Map<ULD>(ULDDto);
            // TODO: Future, we can remove this If this commented part is not required and both tables are saved accordingly.
            //if (uld == null) return ServiceResponseStatus.Failed;
            //var response = await _uLDMetaDataService.CreateAsync(ULDDto.ULDMetaData);

            //if (response.StatusCode == ServiceResponseStatus.Success)
            //{
             //   uld.ULDMetaDataId = response.Id;

            var entity = await _unitOfWork.Repository<ULD>().CreateAsync(uld);
            await _unitOfWork.SaveChangesAsync();
            var response = new ServiceResponseCreateStatus() { Id = entity.Id, StatusCode = ServiceResponseStatus.Success };

            return response;
            //}
            //return ServiceResponseStatus.Failed;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(ULDCreateRM ULDDto)
        {
            var response = new ServiceResponseCreateStatus();

            if (await ValidAsync(ULDDto) == false)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                response.Message = "ULD Number already exists in the system";
                return response;
            }


            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var uldMetadataDto = ULDDto.ULDMetaData;
                    //Volume conversion
                    uldMetadataDto.Length = await _baseUnitConverter.VolumeCalculatorAsync(uldMetadataDto.Length, uldMetadataDto.VolumeUnitId);
                    uldMetadataDto.Height = await _baseUnitConverter.VolumeCalculatorAsync(uldMetadataDto.Height, uldMetadataDto.VolumeUnitId);
                    uldMetadataDto.Width = await _baseUnitConverter.VolumeCalculatorAsync(uldMetadataDto.Width, uldMetadataDto.VolumeUnitId);
                    uldMetadataDto.MaxVolume = await _baseUnitConverter.VolumeCalculatorAsync(uldMetadataDto.MaxVolume, uldMetadataDto.VolumeUnitId);

                    //weight conversion
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (uldMetadataDto.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != uldMetadataDto.WeightUnitId.ToString())
                    {
                        uldMetadataDto.Weight = uldMetadataDto.Weight.GramToKilogramConversion();
                        uldMetadataDto.MaxWeight = uldMetadataDto.MaxWeight.GramToKilogramConversion();
                    }

                    var mapedMetaDeta = _mapper.Map<ULDMetaData>(uldMetadataDto);

                    // Save ULD meta data
                    var uldMetaDetaResponse = await _unitOfWork.Repository<ULDMetaData>().CreateAsync(mapedMetaDeta);
                    await _unitOfWork.SaveChangesAsync();

                    if (uldMetaDetaResponse == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    var mappedULD = _mapper.Map<ULD>(ULDDto);
                    mappedULD.ULDMetaDataId = uldMetaDetaResponse.Id;
                    var uldResponse = await _unitOfWork.Repository<ULD>().CreateAsync(mappedULD);
                    await _unitOfWork.SaveChangesAsync();

                    if (uldResponse == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
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

        public async Task<List<ULD>> GetULDByFlightSchedule(ULDByFlightScheduleRM rm)
        {
            var specs = new FlightScheduleSpecification(rm);
            var schedule = await _unitOfWork.Repository<FlightSchedule>().GetListWithSpecAsync(specs);

            List<ULD> ulds = new List<ULD>();

            foreach (var flightSchedule in schedule)
            {
                if(flightSchedule.FlightScheduleSectors.Count > 0)
                {
                    foreach(var scheduleSector in flightSchedule.FlightScheduleSectors)
                    {
                        foreach(var sectorPallet in scheduleSector.FlightScheduleSectorPallets)
                        {
                            if (sectorPallet.ULD != null)
                            {
                                ulds.Add(sectorPallet.ULD);
                            }
                        }
                    }
                }
            }

            return ulds;
        }

        public async Task<ServiceResponseStatus> UpdateAsync(ULDUpdateRM ULDDto)
        {
            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    var uldMetadataDto = ULDDto.ULDMetaData;

                    //weight conversion
                    var kilogramWeightUnitId = _configuration["BaseUnit:BaseWeightUnitId"];
                    if (uldMetadataDto.WeightUnitId != Guid.Empty && kilogramWeightUnitId.ToLower() != uldMetadataDto.WeightUnitId.ToString())
                    {
                        uldMetadataDto.Weight = uldMetadataDto.Weight.GramToKilogramConversion();
                        uldMetadataDto.MaxWeight = uldMetadataDto.MaxWeight.GramToKilogramConversion();
                    }

                    var mapedMetaDeta = _mapper.Map<ULDMetaData>(uldMetadataDto);

                    _unitOfWork.Repository<ULDMetaData>().Update(mapedMetaDeta);
                    await _unitOfWork.SaveChangesAsync();

                    var mappedULD = _mapper.Map<ULD>(ULDDto);
                    _unitOfWork.Repository<ULD>().Update(mappedULD);
                    await _unitOfWork.SaveChangesAsync();

                    transaction.Commit();
                }
                catch (Exception ex) {
                    transaction.Rollback();
                    throw ex;
                }
            }
            return ServiceResponseStatus.Success;             
        }

        public async Task<ULDDto> GetAsync(ULDQM query)
        {
            var spec = new ULDSpecification(query);
            var uld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(spec);

            return _mapper.Map<ULD, ULDDto>(uld);
        }

        public async Task<Pagination<ULDFilteredListVM>> GetFilteredListAsync(ULDListQM query)
        {
            var spec = new ULDSpecification(query);
            var uldList = await _unitOfWork.Repository<ULD>().GetListWithSpecAsync(spec);

            var countSpec = new ULDSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<ULD>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<ULDFilteredListVM>>(uldList);

            return new Pagination<ULDFilteredListVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        async Task<bool> ValidAsync(ULDCreateRM ULDDto)
        {
            var spec = new ULDSpecification(ULDDto.SerialNumber);
            var uld = await _unitOfWork.Repository<ULD>().GetEntityWithSpecAsync(spec);
            if (uld == null) return true;

            return false;
        }

        public async Task<IReadOnlyList<ULD>> GetULDByStatus()
        {
            var specs = new ULDSpecification();

            var list = await  _unitOfWork.Repository<ULD>().GetListWithSpecAsync(specs);
            return list;
        }
    }
}
