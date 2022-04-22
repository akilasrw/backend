using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.WarehouseQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.WarehouseRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.WarehouseVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class WarehouseService :BaseService, IWarehouseService
    {
        public WarehouseService(IUnitOfWork unitOfWork, IMapper mapper):
            base(unitOfWork, mapper)
        {

        }
       
        public async Task<ServiceResponseStatus> CreateAsync(WarehouseCreateRM model)
        {
            var entity = _mapper.Map<Warehouse>(model);

            await _unitOfWork.Repository<Warehouse>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            return ServiceResponseStatus.Success;
        }

        public async Task<ServiceResponseStatus> UpdateAsync(WarehouseUpdateRM model)
        {
            var entity = _mapper.Map<Warehouse>(model);

            _unitOfWork.Repository<Warehouse>().Update(entity);
            await _unitOfWork.SaveChangesAsync();

            return ServiceResponseStatus.Success;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _unitOfWork.Repository<Warehouse>().GetByIdAsync(id,false);
            entity.IsDeleted = true;
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }

        public async Task<WarehouseVM> GetAsync(WarehouseQM query)
        {
            var spec = new WarehouseSpecification(query);
            var entity = await _unitOfWork.Repository<Warehouse>().GetEntityWithSpecAsync(spec);
            var mappedEntity = _mapper.Map<WarehouseVM>(entity);
            return mappedEntity;
        }
    }
}
