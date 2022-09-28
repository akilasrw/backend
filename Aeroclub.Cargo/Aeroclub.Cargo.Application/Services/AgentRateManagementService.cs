using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.UserResolver.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AgentRateManagementService : BaseService, IAgentRateManagementService
    {
        private readonly IUserResolverService _userResolverService;
        private readonly IUserService _userService;

        public AgentRateManagementService(IUnitOfWork unitOfWork, IMapper mapper,IUserResolverService userResolverService, IUserService userService) : base(unitOfWork, mapper)
        {
            _userResolverService = userResolverService;
            _userService = userService;
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AgentRateManagementListRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                var userid = _userResolverService.GetUserId();
                var currentUser = _userService.GetById(userid);

                if (currentUser == null || dto == null || (dto != null && dto.AgentRateManagements.Count < 1))
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.Failed;
                    return response;
                }
                             
                foreach (var item in dto!.AgentRateManagements)
                {
                    var entity = _mapper.Map<AgentRateManagement>(item);

                    var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(item.OriginAirportId);
                    var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(item.DestinationAirportId);

                    if (originAirport == null || destinationAirport == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    entity.OriginAirportCode = originAirport.Code;
                    entity.OriginAirportName = originAirport.Name;
                    entity.DestinationAirportCode = destinationAirport.Code;
                    entity.DestinationAirportName = destinationAirport.Name;


                    var createdAgentRate = await _unitOfWork.Repository<AgentRateManagement>().CreateAsync(entity);
                    await _unitOfWork.SaveChangesAsync();

                    if (createdAgentRate == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    foreach(var rateItem in item.AgentRates)
                    {
                        var historyEntity = _mapper.Map<AgentRateManagementHistory>(item);

                        historyEntity.OriginAirportCode = originAirport.Code;
                        historyEntity.OriginAirportName = originAirport.Name;
                        historyEntity.DestinationAirportCode = destinationAirport.Code;
                        historyEntity.DestinationAirportName = destinationAirport.Name;
                        historyEntity.Rate = rateItem.Rate;
                        historyEntity.WeightType = rateItem.WeightType;
                        historyEntity.CreatedUser = currentUser.FirstName != null? currentUser.FirstName:"";

                        var createdHistory = await _unitOfWork.Repository<AgentRateManagementHistory>().CreateAsync(historyEntity);
                        await _unitOfWork.SaveChangesAsync();

                        if (createdHistory == null)
                        {
                            transaction.Rollback();
                            response.StatusCode = ServiceResponseStatus.Failed;
                            return response;
                        }
                    }
                }

                transaction.Commit();
            }

            response.StatusCode = ServiceResponseStatus.Success;
            return response;
        }
    }
}
