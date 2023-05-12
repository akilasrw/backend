using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class FlightScheduleSectorPalletService : BaseService, IFlightScheduleSectorPalletService
    {

        public FlightScheduleSectorPalletService(IMapper mapper, IUnitOfWork unitOfWork) :
            base(unitOfWork, mapper)
        {
           
        }

        public async Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleSectorPalletCreateRM rm)
        {
            var flightScheduleSectorPallet = _mapper.Map<FlightScheduleSectorPallet>(rm);

            if (await ValidCountAsync(rm) == false) 
                return new ServiceResponseCreateStatus() { Message = "Pallete assignment is exeeded", StatusCode = ServiceResponseStatus.ValidationError };

            var entity = await _unitOfWork.Repository<FlightScheduleSectorPallet>().CreateAsync(flightScheduleSectorPallet);
            await _unitOfWork.SaveChangesAsync();
            var response = new ServiceResponseCreateStatus() { Id = entity.Id, StatusCode = ServiceResponseStatus.Success };

            return response;
        }

        async Task<bool> ValidCountAsync(FlightScheduleSectorPalletCreateRM rm)
        {
            bool valid = true;

            //---- get max uld qty---
            // get zone id from loadplan id
            // get cargo position from CargoPositions entity => y
            // get added pallet from FlightScheduleSectorPallet => x.

            // if(y>x) return false;

            return valid;
        }
    }
}
