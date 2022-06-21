using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;
using Aeroclub.Cargo.Application.Specifications;
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

        public async Task<ServiceResponseStatus> CreateAsync(SectorDto sectorDto)
        {
            var model = _mapper.Map<Sector>(sectorDto);
            var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);
            var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(model.OriginAirportId);

            model.OriginAirportCode = originAirport.Code;
            model.OriginAirportName = originAirport.Name;
            model.DestinationAirportCode = destinationAirport.Code;
            model.DestinationAirportName = destinationAirport.Name;
            
            var response = await _unitOfWork.Repository<Sector>().CreateAsync(model);
            return ServiceResponseStatus.Success;
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
    }
}