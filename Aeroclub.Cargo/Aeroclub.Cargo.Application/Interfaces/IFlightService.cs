using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightService
    {
        Task<T> GetAsync<T>(FlightQM query);
        Task<IReadOnlyList<T>> GetListAsync<T>(FlightListQM query);
        Task<string> GetFlightNumber(Guid id);
        Task<ServiceResponseCreateStatus> CreateAsync(FlightCreateRM flightRM);
    }
}