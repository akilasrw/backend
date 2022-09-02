using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class FlightScheduleController : BaseApiController
    {
        private readonly IFlightScheduleService _flightScheduleService;

        public FlightScheduleController(IFlightScheduleService flightScheduleService)
        {
            _flightScheduleService = flightScheduleService;
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<FlightScheduleVM>> GetAsync([FromQuery] FlightScheduleQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _flightScheduleService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FlightScheduleCreateRM flightScheduleCreateRM)
        {
            var response = await _flightScheduleService.CreateAsync(flightScheduleCreateRM);
            return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, flightScheduleCreateRM);
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<FlightScheduleVM>>> GetFilteredListAsync([FromQuery] FlightScheduleFilteredListQM query)
        {
            return Ok(await _flightScheduleService.GetFilteredListAsync(query));
        }
    }
}
