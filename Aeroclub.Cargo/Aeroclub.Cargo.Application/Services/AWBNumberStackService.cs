﻿using Aeroclub.Cargo.Application.Enums;
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
                    if (number.AWBTrackingNumber.Equals(dto.AWBTrackingNumber))
                    {
                        res.StatusCode = ServiceResponseStatus.ValidationError;
                        res.Message = "AWB number already taken.";
                        return res;
                    }
                }
            }

            var entity = _mapper.Map<AWBNumberStack>(dto);

            var agent = await _unitOfWork.Repository<CargoAgent>().GetEntityWithSpecAsync(new CargoAgentSpecification());

            entity.CargoAgentId = agent.Id;

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
                    if (number.Id == dto.Id && number.IsUsed)
                    {
                        res.StatusCode = ServiceResponseStatus.ValidationError;
                        res.Message = "AWB number already assigned.";
                        return res;
                    }
                    if (number.AWBTrackingNumber.Equals(dto.AWBTrackingNumber) && number.Id != dto.Id)
                    {
                        res.StatusCode = ServiceResponseStatus.ValidationError;
                        res.Message = "AWB number already taken.";
                        return res;
                    }
                    if (number.AWBTrackingNumber.Equals(dto.AWBTrackingNumber) && dto.CargoAgentId == number.CargoAgentId && number.Id == dto.Id)
                    {
                        res.StatusCode = ServiceResponseStatus.ValidationError;
                        res.Message = "AWB number already added.";
                        return res;
                    }
                    _unitOfWork.Repository<AWBNumberStack>().Detach(number);
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

        public async Task<Pagination<AWBNumberStackVM>> GetFilteredListAsync(AWBNumberStackListQM query)
        {
            var spec = new AWBNumberStackSpecification(query);
            var stackList = await _unitOfWork.Repository<AWBNumberStack>().GetListWithSpecAsync(spec);

            var countSpec = new AWBNumberStackSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<AWBNumberStack>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<AWBNumberStackVM>>(stackList);

            return new Pagination<AWBNumberStackVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<AWBNumberStackVM> GetNextAWBNumberAsync(AvailableAWBNumberStackQM query)
        {
            var spec = new AWBNumberStackSpecification(query);
            var entity = await _unitOfWork.Repository<AWBNumberStack>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<AWBNumberStackVM>(entity);
        }

        public async Task<ServiceResponseStatus> UpdateUsedAWBNumberAsync(Guid awbNumberId)
        {
            var entity = await _unitOfWork.Repository<AWBNumberStack>().GetByIdAsync(awbNumberId);
            if (entity == null)return ServiceResponseStatus.Failed;

            entity.IsUsed = true;
            _unitOfWork.Repository<AWBNumberStack>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AWBNumberStack>().Detach(entity);
            return ServiceResponseStatus.Success;

        }

    }
}
