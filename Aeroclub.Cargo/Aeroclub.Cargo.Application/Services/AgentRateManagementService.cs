using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AgentRateManagementVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using Aeroclub.Cargo.Infrastructure.UserResolver.Interfaces;
using AutoMapper;
using static Google.Rpc.Context.AttributeContext.Types;
using static Grpc.Core.Metadata;

namespace Aeroclub.Cargo.Application.Services
{
    public class AgentRateManagementService : BaseService, IAgentRateManagementService
    {
        private readonly IUserResolverService _userResolverService;
        private readonly IUserService _userService;

        public AgentRateManagementService(IUnitOfWork unitOfWork, IMapper mapper, IUserResolverService userResolverService, IUserService userService) : base(unitOfWork, mapper)
        {
            _userResolverService = userResolverService;
            _userService = userService;
        }

        public async Task<Pagination<AgentRateManagementVM>> GetFilteredListAsync(AgentRateManagementListQM query)
        {
            var specs = new CargoAgentSpecification(query.CargoAgentId);

            if(query.CargoAgentId != Guid.Empty)
            {
                var cargoAgent = await _unitOfWork.Repository<CargoAgent>().GetEntityWithSpecAsync(specs);
                query.CargoAgentId = cargoAgent.Id;
            }

          


            var spec = new AgentRateManagementSpecification(query);
            var agentRateList = await _unitOfWork.Repository<AgentRateManagement>().GetListWithSpecAsync(spec);

            var countSpec = new AgentRateManagementSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<AgentRateManagement>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<AgentRateManagementVM>>(agentRateList);

            return new Pagination<AgentRateManagementVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<IReadOnlyList<SubRateCategory>> GetOtherSubRates(OtherRateTypes id)
        {
            var spec = new SubRatesSpecification(id);
            var subCategoryList = await _unitOfWork.Repository<SubRateCategory>().GetListWithSpecAsync(spec);

            return subCategoryList;

        }

        public async Task<IReadOnlyList<ChildRateCategory>> GetChildRates(Guid subTypeID)
        {
            var spec = new ChildRatesSpecification(subTypeID);
            var childCategoryList = await _unitOfWork.Repository<ChildRateCategory>().GetListWithSpecAsync(spec);

            return childCategoryList;

        }

        public async Task<IReadOnlyList<AgentOtherRates>> FilterOtherRates(Guid childTypeID)
        {
            var spec = new AgentOtherRateSpecification(childTypeID);
            var otherRateList = await _unitOfWork.Repository<AgentOtherRates>().GetListWithSpecAsync(spec);

            return otherRateList;

        }

        public async Task<AgentOtherRates> CreateOtherRates(AgentOtherRatesRM model)
        {
            var otherRate = new AgentOtherRates
            {
                ChildCategoryID = model.SubCategoryID,
                RateName = model.RateName,
                Description = model.Description,
                RateDescription = model.RateDescription,
                MinPreceptionRate = model.MinPreceptionRate,
                RatePerKG = model.RatePerKG,
                FixRate = model.FixRate,
                TrancheRate = model.TrancheRate,
                IATACode = model.IATACode
            };
            var createdOtherRate = await _unitOfWork.Repository<AgentOtherRates>().CreateAsync(otherRate);
            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return createdOtherRate;

        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(AgentRateManagementListRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {

                if (dto == null || (dto != null && dto.AgentRateManagements.Count < 1))
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.Failed;
                    return response;
                }

                foreach (var item in dto!.AgentRateManagements)
                {

                    var spec = new AgentRateManagementSpecification(new AgentRateManagementValidationQM
                    {
                        IncludeAgentRates = false,
                        CargoAgentId = item.CargoAgentId,
                        DestinationAirportId = item.DestinationAirportId,
                        OriginAirportId = item.OriginAirportId,
                        ValidStartDate = item.StartDate,
                        ValidEndDate = item.EndDate,
                        CargoType = item.CargoType,
                        RateType = item.RateType

                    });


                    if (dto.AgentRateManagements[0].CargoAgentId == null)
                    {
                        dto.AgentRateManagements[0].CargoAgentId = null;
                    }
                    else
                    {
                        var cargoAgent = await _unitOfWork.Repository<CargoAgent>().GetEntityWithSpecAsync(new CargoAgentSpecification(dto.AgentRateManagements[0].CargoAgentId));
                        dto.AgentRateManagements[0].CargoAgentId = cargoAgent.Id;
                    }

                    

                    var agentRate = await _unitOfWork.Repository<AgentRateManagement>().GetEntityWithSpecAsync(spec);

                    if (agentRate != null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                        response.Message = string.Format("{0} and {1} already exist for selected user and selected dates ({2} - {3})",
                            agentRate.OriginAirportCode, agentRate.DestinationAirportCode, agentRate.StartDate.ToShortDateString(), agentRate.EndDate.ToShortDateString());
                        return response;
                    }

                    var entity = _mapper.Map<AgentRateManagement>(item);

                    var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(item.OriginAirportId);
                    var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(item.DestinationAirportId);

                    if (originAirport == null || destinationAirport == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.Failed;
                        return response;
                    }

                    if (entity.AgentRates == null)
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                        response.Message = "Agent rates required.";
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
                }

                transaction.Commit();
            }

            response.StatusCode = ServiceResponseStatus.Success;
            return response;
        }

        public async Task<AgentRateManagementVM> GetAsync(AgentRateManagementQM query)
        {
            var spec = new AgentRateManagementSpecification(query);
            var entity = await _unitOfWork.Repository<AgentRateManagement>().GetEntityWithSpecAsync(spec);
            var agentRateManagementVM = _mapper.Map<AgentRateManagement, AgentRateManagementVM>(entity);
            return agentRateManagementVM;
        }

        public async Task<ServiceResponseCreateStatus> DeleteAsync(Guid Id)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {

                var rateManagement = await _unitOfWork.Repository<AgentRateManagement>().GetEntityWithSpecAsync(new AgentRateManagementSpecification(new AgentRateManagementQM { Id = Id, IncludeCargoAgent = false }));
                if (rateManagement == null)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.ValidationError;
                    response.Message = "Record not found";
                    return response;
                }

                var createdHistory = await SaveRateHistory(rateManagement, DBTransactionStatus.Deleted);

                if (createdHistory != ServiceResponseStatus.Success)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.Failed;
                    return response;
                }

                foreach (var rateItem in rateManagement.AgentRates)
                {
                    _unitOfWork.Repository<AgentRate>().Delete(rateItem);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<AgentRate>().Detach(rateItem);
                }

                _unitOfWork.Repository<AgentRateManagement>().Delete(rateManagement);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<AgentRateManagement>().Detach(rateManagement);

                transaction.Commit();
            }

            response.StatusCode = ServiceResponseStatus.Success;
            return response;
        }

        public async Task<ServiceResponseCreateStatus> UpdateAsync(AgentRateManagementUpdateRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                var entity = _mapper.Map<AgentRateManagement>(dto);

                if (entity.AgentRates == null)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.ValidationError;
                    response.Message = "Agent rates required.";
                    return response;
                }

                var spec = new AgentRateManagementSpecification(new AgentRateManagementUpdateQM
                {
                    IncludeAgentRates = true,
                    CargoAgentId = entity.CargoAgentId,
                    DestinationAirportId = entity.DestinationAirportId,
                    OriginAirportId = entity.OriginAirportId,
                    ValidEndDate = entity.EndDate,
                    ValidStartDate = entity.StartDate,
                });

                //commenting this out to the favor of updating the things like rate type other than rates

                //var agentRate = await _unitOfWork.Repository<AgentRateManagement>().GetEntityWithSpecAsync(spec);

                /*if (agentRate != null && agentRate.AgentRates != null)
                {
                    bool isAllRatesSame = true;

                    foreach (var existingItem in agentRate.AgentRates)
                        foreach(var newItem in entity.AgentRates)
                        {
                            if(existingItem.WeightType == newItem.WeightType && existingItem.Rate != newItem.Rate)
                                isAllRatesSame = false;
                        }
                    
                    if (isAllRatesSame || (agentRate.Id != entity.Id))
                    {
                        transaction.Rollback();
                        response.StatusCode = ServiceResponseStatus.ValidationError;
                        response.Message = "This record is already available.";
                        return response;
                    }  
                }*/

                var originAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(entity.OriginAirportId);
                var destinationAirport = await _unitOfWork.Repository<Airport>().GetByIdAsync(entity.DestinationAirportId);

                if (originAirport == null || destinationAirport == null)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.Failed;
                    return response;
                }

                var rateManagement = await _unitOfWork.Repository<AgentRateManagement>().GetEntityWithSpecAsync(new AgentRateManagementSpecification(new AgentRateManagementQM { Id = dto.Id, IncludeCargoAgent = false }));
                if (rateManagement == null)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.ValidationError;
                    response.Message = "Record not found";
                    return response;
                }

                var createdHistory = await SaveRateHistory(rateManagement, DBTransactionStatus.Updated);

                if (createdHistory != ServiceResponseStatus.Success)
                {
                    transaction.Rollback();
                    response.StatusCode = ServiceResponseStatus.Failed;
                    return response;
                }

                entity.OriginAirportCode = originAirport.Code;
                entity.OriginAirportName = originAirport.Name;
                entity.DestinationAirportCode = destinationAirport.Code;
                entity.DestinationAirportName = destinationAirport.Name;

                foreach (var rateItem in entity.AgentRates)
                {
                    _unitOfWork.Repository<AgentRate>().Update(rateItem);
                    await _unitOfWork.SaveChangesAsync();
                    _unitOfWork.Repository<AgentRate>().Detach(rateItem);
                }

                _unitOfWork.Repository<AgentRateManagement>().Update(entity);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<AgentRateManagement>().Detach(entity);

                transaction.Commit();

            }
            response.StatusCode = ServiceResponseStatus.Success;
            return response;
        }

        private async Task<ServiceResponseStatus> SaveRateHistory(AgentRateManagement rateManagement, DBTransactionStatus status)
        {
            var userid = _userResolverService.GetUserId();
            var currentUser = _userService.GetById(userid);

            if (currentUser == null || rateManagement == null || (rateManagement != null && rateManagement.AgentRates == null))
                return ServiceResponseStatus.Failed;


            foreach (var rateItem in rateManagement.AgentRates)
            {
                var historyEntity = _mapper.Map<AgentRateManagementHistory>(rateManagement);
                historyEntity.Id = Guid.Empty;
                historyEntity.Status = status;
                historyEntity.Rate = rateItem.Rate;
                historyEntity.WeightType = rateItem.WeightType;
                historyEntity.CreatedUser = currentUser.FirstName != null ? currentUser.FirstName : "";

                var createdHistory = await _unitOfWork.Repository<AgentRateManagementHistory>().CreateAsync(historyEntity);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Repository<AgentRateManagementHistory>().Detach(historyEntity);

                if (createdHistory == null)
                    return ServiceResponseStatus.Failed;
            }

            return ServiceResponseStatus.Success;
        }

        public async Task<Pagination<AgentRateManagementVM>> GetFilteredAgentRateListAsync(AgentRateManagementRateListQM query)
        {
            var spec = new AgentRateManagementSpecification(query);
            var agentRateList = await _unitOfWork.Repository<AgentRateManagement>().GetListWithSpecAsync(spec);

            var countSpec = new AgentRateManagementSpecification(query, true);
            var totalCount = await _unitOfWork.Repository<AgentRateManagement>().CountAsync(countSpec);

            var dtoList = _mapper.Map<IReadOnlyList<AgentRateManagementVM>>(agentRateList);

            return new Pagination<AgentRateManagementVM>(query.PageIndex, query.PageSize, totalCount, dtoList);
        }

        public async Task<ServiceResponseCreateStatus> UpdateActiveStatusAsync(AgentRateStatusUpdateRM dto)
        {
            var response = new ServiceResponseCreateStatus();

            var rateManagement = await _unitOfWork.Repository<AgentRateManagement>().GetEntityWithSpecAsync(new AgentRateManagementSpecification(new AgentRateManagementQM { Id = dto.Id, IncludeCargoAgent = false }));

            if (rateManagement == null)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                response.Message = "Record not found";
                return response;
            }

            rateManagement.IsActive = dto.IsActive;

            _unitOfWork.Repository<AgentRateManagement>().Update(rateManagement);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AgentRateManagement>().Detach(rateManagement);

            response.StatusCode = ServiceResponseStatus.Success;
            return response;
        }
    }
}
