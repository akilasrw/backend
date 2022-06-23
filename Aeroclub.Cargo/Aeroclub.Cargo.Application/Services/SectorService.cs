using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class SectorService :BaseService, ISectorService
    {

        public SectorService(IUnitOfWork unitOfWork, IMapper mapper):
            base(unitOfWork,mapper)
        {
           
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(SectorCreateRM model)
        {
            var response = new ServiceResponseCreateStatus();
            bool IsSectorAvailable = await IsSectorAlreadyAvailable(model.OriginAirportId, model.DestinationAirportId, model.SectorType);
            if (IsSectorAvailable)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                return response;
            }

            var entity = _mapper.Map<Sector>(model);
            var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);
            var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.DestinationAirportId);

            entity.OriginAirportCode = originAirport.Code;
            entity.OriginAirportName = originAirport.Name;
            entity.DestinationAirportCode = destinationAirport.Code;
            entity.DestinationAirportName = destinationAirport.Name;
            
            await _unitOfWork.Repository<Sector>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            response.Id = entity.Id;
            response.StatusCode = ServiceResponseStatus.Success;


            if (model.IsCreateReturnSector)
            {
                bool IsReturnSectorAvailable = await IsSectorAlreadyAvailable(model.DestinationAirportId, model.OriginAirportId, model.SectorType);

                if (IsReturnSectorAvailable)
                {
                    return response;
                }

                var retunSector = new Sector();
                retunSector.OriginAirportId = model.DestinationAirportId;
                retunSector.DestinationAirportId = model.OriginAirportId;
                retunSector.OriginAirportCode = destinationAirport.Code;
                retunSector.OriginAirportName = destinationAirport.Name;
                retunSector.DestinationAirportCode = originAirport.Code;
                retunSector.DestinationAirportName = originAirport.Name;
                retunSector.SectorType = model.SectorType;

                await _unitOfWork.Repository<Sector>().CreateAsync(retunSector);
                await _unitOfWork.SaveChangesAsync();
            }

            return response;
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {
            var entity = await _unitOfWork.Repository<Sector>().GetByIdAsync(Id, false);
            entity.IsDeleted = true;
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }

        public async Task<SectorVM> GetAsync(SectorQM query)
        {
            var spec = new SectorSpecification(query);
            var sector = await _unitOfWork.Repository<Sector>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<SectorVM>(sector);
        }

        public async Task<Pagination<SectorVM>> GetFilteredListAsync(SectorListQM query)
        {
            var spec = new SectorSpecification(query);
            var sectorList = await _unitOfWork.Repository<Sector>().GetListWithSpecAsync(spec);

            var countSpec = new SectorSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<Sector>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<SectorVM>>(sectorList);

            return new Pagination<SectorVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(SectorUpdateRM model)
        {
            bool IsSectorAvailable = await IsSectorAlreadyAvailable(model.OriginAirportId, model.DestinationAirportId, model.SectorType);
            if (IsSectorAvailable)
            {
                return ServiceResponseStatus.ValidationError;
            }

            var entity =  await _unitOfWork.Repository<Sector>().GetByIdAsync(model.Id);
            var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);
            var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.DestinationAirportId);

            entity.OriginAirportId = model.OriginAirportId;
            entity.DestinationAirportId = model.DestinationAirportId;
            entity.SectorType = model.SectorType;
            entity.OriginAirportCode = originAirport.Code;
            entity.OriginAirportName = originAirport.Name;
            entity.DestinationAirportCode = destinationAirport.Code;
            entity.DestinationAirportName = destinationAirport.Name;

            _unitOfWork.Repository<Sector>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<Sector>().Detach(entity);
            return ServiceResponseStatus.Success;
        }

        private async Task<bool> IsSectorAlreadyAvailable(Guid OriginAirportId,Guid DestinationAirportId,SectorType SectorType)
        {
            var sectorList = await _unitOfWork.Repository<Sector>().GetListAsync();
            if(sectorList != null && sectorList.Count>0)
            {
                foreach (var sector in sectorList)
                {
                    if (!sector.IsDeleted && 
                        OriginAirportId == sector.OriginAirportId && 
                        DestinationAirportId == sector.DestinationAirportId &&
                        SectorType == sector.SectorType)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}