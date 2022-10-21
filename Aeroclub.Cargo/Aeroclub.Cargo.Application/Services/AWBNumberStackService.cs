using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberStackRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBNumberStackVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AWBNumberStackService : BaseService, IAWBNumberStackService
    {
        public AWBNumberStackService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AWBNumberStackCreateRM dto)
        {
            var res = new ServiceResponseCreateStatus();

            var existingNumbers = await _unitOfWork.Repository<AWBNumberStack>().GetListAsync();
            if (existingNumbers != null && existingNumbers.Count>0)
            {
                foreach (var number in existingNumbers)
                {
                    if (number.AWMTrackingNumber.Equals(dto.AWMTrackingNumber))
                    {
                        res.StatusCode = ServiceResponseStatus.ValidationError;
                        res.Message = "AWB number already taken.";
                        return res;
                    }
                }
            }

            var entity = _mapper.Map<AWBNumberStack>(dto);
            await _unitOfWork.Repository<AWBNumberStack>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            res.StatusCode = ServiceResponseStatus.Success;
            res.Message = "AWB number successfully added.";
            res.Id = entity.Id;
            return res;
        }

        public async Task<AWBNumberStackVM> GetAsync(AWBNumberStackQM query)
        {
            var spec = new AWBNumberStackSpecification(query);
            var entity = await _unitOfWork.Repository<AWBNumberStack>().GetEntityWithSpecAsync(spec);

            var mappedEntity = _mapper.Map<AWBNumberStackVM>(entity);

            return mappedEntity;
        }

        public async Task<ServiceResponseCreateStatus> UpdateAsync(AWBNumberStackUpdateRM dto)
        {
            var res = new ServiceResponseCreateStatus();

            var existingNumbers = await _unitOfWork.Repository<AWBNumberStack>().GetListAsync();
            if (existingNumbers != null && existingNumbers.Count > 0)
            {
                foreach (var number in existingNumbers)
                {
                    if (number.AWMTrackingNumber.Equals(dto.AWMTrackingNumber) && number.Id != dto.Id)
                    {
                        res.StatusCode = ServiceResponseStatus.ValidationError;
                        res.Message = "AWB number already taken.";
                        return res;
                    }
                }
            }

            var entity = _mapper.Map<AWBNumberStack>(dto);
            _unitOfWork.Repository<AWBNumberStack>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AWBNumberStack>().Detach(entity);

            res.StatusCode = ServiceResponseStatus.Success;
            res.Id = entity.Id;
            return res;
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {
            var entity = await _unitOfWork.Repository<AWBNumberStack>().GetByIdAsync(Id);
            _unitOfWork.Repository<AWBNumberStack>().Delete(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AWBNumberStack>().Detach(entity);
            return (await _unitOfWork.SaveChangesAsync() > 0);
        }
    }
}
