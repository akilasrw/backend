using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorPalletRMs;
using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightScheduleSectorPalletService
    {
        Task<ServiceResponseCreateStatus> CreateAsync(FlightScheduleSectorPalletCreateRM rm);
        Task<bool> DeleteAsync(FlightScheduleSectorPallet entity);
        Task<ServiceResponseStatus> CreateRemovePalletListAsync(FlightScheduleSectorPalletCreateListRM request);
        
    }
}
