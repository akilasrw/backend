
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;

namespace Aeroclub.Cargo.Application.Services
{
    public class AWBService : BaseService, IAWBService
    {

        public AWBService(IUnitOfWork unitOfWork, IMapper mapper) :base(unitOfWork,mapper)
        {

        }
        public async Task<AWBCreateStatusVM> CreateAsync(AWBCreateRM model)
        {
            var response = new AWBCreateStatusVM();

            var awb = _mapper.Map<AWBInformation>(model);

            var createdAWB = await _unitOfWork.Repository<AWBInformation>().CreateAsync(awb);
            await _unitOfWork.SaveChangesAsync();

            if (createdAWB != null)
            {
                response.StatusCode = ServiceResponseStatus.Success;
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
