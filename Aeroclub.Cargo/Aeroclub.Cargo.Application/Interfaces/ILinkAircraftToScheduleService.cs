﻿using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ILinkAircraftToScheduleService
    {
        Task<ServiceResponseStatus> CreateAsync(ScheduleAircraftRM query);
        Task<IReadOnlyList<FlightScheduleManagementLinkAircraftVM>> GetLinkAircraftFilteredListAsync(FlightScheduleManagemenLinktFilteredListQM query);
    }
}
