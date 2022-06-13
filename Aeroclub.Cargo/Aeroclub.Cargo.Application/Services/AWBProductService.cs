using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AWBProductService : BaseService, IAWBProductService
    {
      
        public AWBProductService(IUnitOfWork unitOfWork, IMapper mapper) 
            : base(unitOfWork, mapper)
        {
      
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AWBProductRM dto)
        {
            var res = new ServiceResponseCreateStatus();

            
            var awbProduct = _mapper.Map<AWBProduct>(dto);
            await _unitOfWork.Repository<AWBProduct>().CreateAsync(awbProduct);
            await _unitOfWork.SaveChangesAsync();

            res.StatusCode = ServiceResponseStatus.Success;
            res.Id = awbProduct.Id;

            return res;
        }

        public async Task<ServiceResponseStatus> UpdateAsync(AWBProductRM model)
        {
            var entity = _mapper.Map<AWBProduct>(model);
            _unitOfWork.Repository<AWBProduct>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AWBProduct>().Detach(entity);
            return ServiceResponseStatus.Success;
        }
    }
}
