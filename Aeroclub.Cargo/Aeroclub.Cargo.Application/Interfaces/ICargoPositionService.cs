﻿using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.PackageItemRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SeatConfigurationVM;
using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ICargoPositionService
    {
        Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingCargoPositionAsync(PackageItemCreateRM packageItem, Guid aircraftLayoutId, CargoPositionType cargoPositionType);
        Task<List<Tuple<CargoPosition, Guid?>>> GetMatchingThreeSeatCargoPositionAsync(PackageItemCreateRM packageItem, Guid aircraftLayoutId, SeatConfigurationType seatConfigurationType);
        Task<ValidateResponse> ValidateCargoPositionAsync(ValidateCargoPositionRM rm);
        Task<SeatAvailabilityVM> GetAvailableThreeSeatAsync(FlightScheduleSectorQM qm);
        Task<List<CargoPositionVM>> GetSummeryCargoPositionAsync(Guid aircraftLayoutId);

        Task UpdateCargoPositionPropertiesAsync(Guid cargoPositionId, double newHeight, double newMaxWeight, double newMaxVolume);

    }
}
