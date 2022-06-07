﻿
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBStackRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AWBService : BaseService, IAWBService
    {
        private readonly IAWBStackService _awbStackService;
        public AWBService(IAWBStackService awbStackService,IUnitOfWork unitOfWork, IMapper mapper) :base(unitOfWork,mapper)
        {
            _awbStackService = awbStackService;
        }
        public async Task<AWBCreateStatusRM> CreateAsync(AWBCreateRM model)
        {
            var response = new AWBCreateStatusRM();

            var awb = _mapper.Map<AWBInformation>(model);

            var awbNumber = await _awbStackService.GetNextAWBNumberAsync(new AWBNumberStackQM() { CargoAgentId = model.UserId});

            awb.AwbTrackingNumber = awbNumber.AWBNumber;

            var createdAWB = await _unitOfWork.Repository<AWBInformation>().CreateAsync(awb);
            await _unitOfWork.SaveChangesAsync();

            if (createdAWB != null)
            {
                var awbNumberUpdate = await _awbStackService.UpdateUsedAWBNumberAsync(new AWBStackUpdateRM() 
                { CargoAgentId = model.UserId,LastUsedSequenceNumber = awbNumber.AWBNumber });

                response.StatusCode = awbNumberUpdate;
            }
            else
            {
                response.StatusCode = ServiceResponseStatus.Failed;
            }
            return response;
        }

        public async Task<AWBInformationVM> GetAsync(AirWayBillQM query)
        {
            var spec = new AWBSpecification(query);
            var awb = await _unitOfWork.Repository<AWBInformation>().GetEntityWithSpecAsync(spec);

            return _mapper.Map<AWBInformation, AWBInformationVM>(awb);
        }
    }
}
