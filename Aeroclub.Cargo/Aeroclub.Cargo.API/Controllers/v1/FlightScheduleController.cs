using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleVMs;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<FlightScheduleSectorVM>>> GetFilteredListAsync([FromQuery] FlightScheduleFilteredListQM query)
        {
            return Ok(await _flightScheduleService.GetFilteredListAsync(query));
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

        [HttpGet("GetListByMasterId")]
        public async Task<ActionResult<IReadOnlyList<FlightScheduleLinkVM>>> GetListByMasterIdAsync([FromQuery] FlightScheduleLinkQM query)
        {
            return Ok(await _flightScheduleService.GetListByMasterIdAsync(query));
        }
        
        [HttpGet("GetByIdAsync")]
        public async Task<ActionResult<FlightScheduleLinkVM>> GetByIdAsync([FromQuery] FlightScheduleLinkQM query)
        {
            return Ok(await _flightScheduleService.GetByIdAsync(query));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FlightScheduleCreateRM flightScheduleCreateRM)
        {
            var response = await _flightScheduleService.CreateAsync(flightScheduleCreateRM);
            return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, flightScheduleCreateRM);
        }

        [HttpGet("GetAircraftsByFlightScheduleId/{flightScheduleId}")]
        public async Task<ActionResult<AircraftDto>> GetAvailableAircrafts_ByFlightScheduleIdAsync(Guid flightScheduleId)
        {
            return Ok(await _flightScheduleService.GetAvailableAircrafts_ByFlightScheduleIdAsync(flightScheduleId));
        }

        [HttpPut("UpdateATA/{id}")]
        public async Task<IActionResult> UpdateATAAsync(Guid id, UpdateATARM model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            var res = await _flightScheduleService.UpdateATAAsync(model);

            if(res == Application.Enums.ServiceResponseStatus.ValidationError)
                return BadRequest("Flight Schedule is not valid.");

            if (res == Application.Enums.ServiceResponseStatus.Failed)
                return BadRequest("Saved failed.");

            return NoContent();
        }
    }
}
