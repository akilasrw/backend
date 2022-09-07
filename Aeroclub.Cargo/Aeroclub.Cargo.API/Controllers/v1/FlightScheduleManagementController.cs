using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
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

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<FlightScheduleManagementVM>> GetAsync([FromQuery] FlightScheduleManagementDetailQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _flightScheduleManagementService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<FlightScheduleManagementVM>>> GetFilteredListAsync([FromQuery] FlightScheduleManagementFilteredListQM query)
        {
            return Ok(await _flightScheduleManagementService.GetFilteredListAsync(query));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FlightScheduleManagementRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _flightScheduleManagementService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("Flight schedule creation fails.");
        }

    }
}
