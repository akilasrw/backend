using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberRMs;
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

        public async Task<Pagination<AWBStackVM>> GetBookingFilteredListAsync(AWBStackListQM query)
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
            var mappedEntity = new AWBStackVM() { EndSequenceNumber = 0};

            var entityList = await _unitOfWork.Repository<AWBStack>().GetListAsync();

            if (entityList != null && entityList.Count >0)
                mappedEntity = _mapper.Map<AWBStackVM>(entityList.Last()); 
            
            return mappedEntity;
        }

    }
}
