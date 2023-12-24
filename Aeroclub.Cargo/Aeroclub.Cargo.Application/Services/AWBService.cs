using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.Notification;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AWBService : BaseService, IAWBService
    {
        private readonly IAWBNumberStackService _awbNumberStackService;
        private readonly ICargoBookingService _cargoBookingService;
        private readonly INotificationService _notificationService;
        public AWBService(ICargoBookingService cargoBookingService, IAWBNumberStackService awbNumberStackService, INotificationService notificationService, IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _awbNumberStackService = awbNumberStackService;
            _cargoBookingService = cargoBookingService;
            _notificationService = notificationService;
        }

        public async Task<AWBCreateStatusRM> CreateAsync(AWBCreateRM model)
        {
            var response = new AWBCreateStatusRM();


            var awb = _mapper.Map<AWBInformation>(model);
            var awbNumber = await _awbNumberStackService.GetNextAWBNumberAsync(new AvailableAWBNumberStackQM() { CargoAgentId = model.UserId,IsAgentInclude=true });
            
            if (awbNumber == null)
            {
                response.StatusCode = ServiceResponseStatus.ValidationError;
                return response;
            }

            awb.AwbTrackingNumber = awbNumber.AWBTrackingNumber;

            var createdAWB = await _unitOfWork.Repository<AWBInformation>().CreateAsync(awb);
            await _unitOfWork.SaveChangesAsync();

            if (createdAWB == null)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }

            var updatedAWBStatus = await _cargoBookingService.UpdateAWBStatus(model.CargoBookingId);
            if(updatedAWBStatus == ServiceResponseStatus.Success)
            {
                NotificationRM notificationRM = new NotificationRM();
                notificationRM.Title = "AWB created";
                notificationRM.Body = "AWB created";
                notificationRM.NotificationType = Common.Enums.NotificationType.AWB_Added;
                await _notificationService.CreateAsync(notificationRM);
            }

            if (updatedAWBStatus == ServiceResponseStatus.Failed)
            {
                response.StatusCode = ServiceResponseStatus.Failed;
                return response;
            }
            if(awbNumber != null)
            {
                var awbNumberUpdate = await _awbNumberStackService.UpdateUsedAWBNumberAsync(awbNumber.Id);

                if (awbNumberUpdate == ServiceResponseStatus.Failed)
                {
                    response.StatusCode = ServiceResponseStatus.Failed;
                    return response;
                }
                else
                {
                    response.StatusCode = awbNumberUpdate;
                }
            }
           

            return response;
        }

        public async Task<AWBInformationVM> GetAsync(AirWayBillQM query)
        {
            var spec = new AWBSpecification(query);
            var awb = await _unitOfWork.Repository<AWBInformation>().GetEntityWithSpecAsync(spec);

            return _mapper.Map<AWBInformation, AWBInformationVM>(awb);
        }

        public async Task<ServiceResponseStatus> UpdateAsync(AWBUpdateRM model)
        {
            var entity = _mapper.Map<AWBInformation>(model);
            _unitOfWork.Repository<AWBInformation>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<AWBInformation>().Detach(entity);
            return ServiceResponseStatus.Success;
        }
    }
}
