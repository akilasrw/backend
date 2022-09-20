using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IFlightService
    {
        Task<T> GetAsync<T>(FlightQM query);
        Task<IReadOnlyList<T>> GetListAsync<T>(FlightListQM query);
        Task<string> GetFlightNumber(Guid id);
        Task<ServiceResponseCreateStatus> CreateAsync(FlightCreateRM flightRM);
        Task<Pagination<FlightFilterVM>> GetFilteredListAsync(FlightFilterListQM query);
        Task<bool> IsExistsAsync(FlightCreateRM dto);
        Task<IReadOnlyList<BaseSelectListModel>> GetSelectListAsync();
        Task<FlightVM> GetDetailAsync(FlightDetailQM query);
        Task<ServiceResponseStatus> UpdateAsync(FlightCreateRM flightRM);
        Task<ServiceResponseStatus> DeleteAsync(Guid Id);
    }
}