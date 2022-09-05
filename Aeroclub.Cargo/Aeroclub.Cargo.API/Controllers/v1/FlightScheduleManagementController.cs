using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleManagementVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class FlightScheduleManagementController : BaseApiController
    {
        private readonly IFlightScheduleManagementService _flightScheduleManagementService;

        public FlightScheduleManagementController(IFlightScheduleManagementService flightScheduleManagementService)
        {
            _flightScheduleManagementService = flightScheduleManagementService;
        }


        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<FlightScheduleManagementVM>>> GetFilteredListAsync([FromQuery] FlightScheduleManagementFilteredListQM query)
        {
            return Ok(await _flightScheduleManagementService.GetFilteredListAsync(query));
        }

    }
}
