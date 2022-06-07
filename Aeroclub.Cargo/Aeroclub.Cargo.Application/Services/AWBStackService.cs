using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBStackRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBStackVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AWBStackService : BaseService, IAWBStackService
    {
        public AWBStackService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AWBStackRM dto)
        {
            var res = new ServiceResponseCreateStatus();

            var lastRecord = await GetLastRecordAsync();
            if (lastRecord != null &&
                (lastRecord.EndSequenceNumber > dto.StartSequenceNumber ||
                lastRecord.EndSequenceNumber > dto.EndSequenceNumber))
            {
                res.StatusCode = ServiceResponseStatus.ValidationError;
                return res;
            }
               
            if (dto.StartSequenceNumber > dto.EndSequenceNumber)
            {
                res.StatusCode = ServiceResponseStatus.ValidationError;
                return res;
            }

            var awbStack = _mapper.Map<AWBStack>(dto);
            await _unitOfWork.Repository<AWBStack>().CreateAsync(awbStack);
            await _unitOfWork.SaveChangesAsync();

            res.StatusCode = ServiceResponseStatus.Success;
            res.Id = awbStack.Id;

            return res;
        }

        public async Task<AWBStackVM> GetAsync(AWBStackQM query)
        {
            var spec = new AWBStackSpecification(query);
            var entity = await _unitOfWork.Repository<AWBStack>().GetEntityWithSpecAsync(spec);

            var mappedEntity = _mapper.Map<AWBStackVM>(entity);

            return mappedEntity;
        }

        public async Task<Pagination<AWBStackVM>> GetAWBStackFilteredListAsync(AWBStackListQM query)
        {
            var spec = new AWBStackSpecification(query);
            var stackList = await _unitOfWork.Repository<AWBStack>().GetListWithSpecAsync(spec);

            var countSpec = new AWBStackSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<AWBStack>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<AWBStackVM>>(stackList);

            return new Pagination<AWBStackVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<AWBStackVM> GetLastRecordAsync()
        {
            var mappedEntity = new AWBStackVM();

            var entityList = await _unitOfWork.Repository<AWBStack>().GetListAsync();

            if (entityList != null && entityList.Count >0)
                mappedEntity = _mapper.Map<AWBStackVM>(entityList.Last()); 
            
            return mappedEntity;
        }

        public async Task<AWBNumbeStackVM> GetNextAWBNumberAsync(AWBNumberStackQM query)
        {

            var spec = new AWBStackSpecification(query);

            var entity = await _unitOfWork.Repository<AWBStack>().GetEntityWithSpecAsync(spec);

            var NumberStack = new AWBNumbeStackVM();

            if (entity != null)
            {
                NumberStack.Id = entity.Id;

                if (entity.LastUsedSequenceNumber != 0)
                {
                    if(entity.LastUsedSequenceNumber < entity.EndSequenceNumber)
                        NumberStack.AWBNumber = entity.LastUsedSequenceNumber + 1;
                }
                else
                {
                    if (entity.StartSequenceNumber < entity.EndSequenceNumber)
                        NumberStack.AWBNumber = entity.StartSequenceNumber;                   
                }
            }

            return NumberStack;
        }

        public async Task<ServiceResponseStatus> UpdateUsedAWBNumberAsync(AWBStackUpdateRM dto)
        {
            var spec = new AWBStackSpecification(new AWBNumberStackQM() { CargoAgentId = dto.CargoAgentId});

            var entity = await _unitOfWork.Repository<AWBStack>().GetEntityWithSpecAsync(spec);

            entity.LastUsedSequenceNumber = dto.LastUsedSequenceNumber;

            if(entity.LastUsedSequenceNumber == entity.EndSequenceNumber)
                entity.IsSequenceCompleted = true;

            _unitOfWork.Repository<AWBStack>().Update(entity);
            await _unitOfWork.SaveChangesAsync();

            return ServiceResponseStatus.Success;

        }
    }
}
