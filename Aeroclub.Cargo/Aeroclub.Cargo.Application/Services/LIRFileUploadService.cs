using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.LIRFileUploadQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Aeroclub.Cargo.Application.Specifications;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class LIRFileUploadService : BaseService,ILIRFileUploadService
    {
        public LIRFileUploadService(IUnitOfWork unitOfWork,
            IMapper mapper) :
            base(unitOfWork, mapper)
        {

        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(LIRFileUploadDto model)
        {
            var res = new ServiceResponseCreateStatus();
            var entity = _mapper.Map<LIRFileUploadDto, LIRFileUpload>(model);

            await _unitOfWork.Repository<LIRFileUpload>().CreateAsync(entity);
            await _unitOfWork.SaveChangesAsync();

            res.Id = entity.Id;
            res.StatusCode = ServiceResponseStatus.Success;
            return res;
        }
        
        public async Task<ServiceResponseStatus> UpdateAsync(LIRFileUploadDto model)
        {
            var entity = _mapper.Map<LIRFileUpload>(model);
            _unitOfWork.Repository<LIRFileUpload>().Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.Repository<LIRFileUpload>().Detach(entity);
            return ServiceResponseStatus.Success;
            
        } 

        public async Task<LIRFileUploadDto> GetAsync(LIRFileUploadQM query)
        {
            var spec = new LIRFileUploadSpecification(query);
            var res = await _unitOfWork.Repository<LIRFileUpload>().GetEntityWithSpecAsync(spec);
            return _mapper.Map<LIRFileUploadDto>(res);
        }
    }
}
