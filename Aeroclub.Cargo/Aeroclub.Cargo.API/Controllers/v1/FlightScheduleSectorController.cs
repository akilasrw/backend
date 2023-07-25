﻿using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightScheduleSectorVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]    
    public class FlightScheduleSectorController : BaseApiController
    {
        private readonly IFlightScheduleSectorService _flightScheduleSectorService;

        public FlightScheduleSectorController(IFlightScheduleSectorService flightScheduleSectorService)
        {
            _flightScheduleSectorService = flightScheduleSectorService;
        }

        [HttpGet("GetList")]
        public async Task<ActionResult<IReadOnlyList<FlightScheduleSectorVM>>> GetListAsync([FromQuery] FlightScheduleSectorListQM query)
        {
            return Ok(await _flightScheduleSectorService.GetListAsync<FlightScheduleSectorVM>(query));
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<FlightScheduleSectorVM>> GetAsync([FromQuery] FlightScheduleSectorQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _flightScheduleSectorService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
        
        [HttpGet("GetFlightScheduleWithULDCount")]
        public async Task<ActionResult<FlightScheduleSectorVM>> GetFlightScheduleWithULDCountAsync([FromQuery] FlightScheduleSectorULDPositionCountQM query)
        {
            if (query.ScheduledDepartureStartDateTime == DateTime.MinValue || query.ScheduledDepartureEndDateTime == DateTime.MinValue)
            {
                return BadRequest("Dates are not valid.");
            }

            var result = await _flightScheduleSectorService.GetFlightScheduleSectorWithULDPositionCountAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] FlightScheduleSectorCreateRM dto)// TODO: Need to be removed. this part should be happening with creation of flightScheduleController
        {
            if(!ModelState.IsValid) 
                    return BadRequest(ModelState);
            
            var response = await _flightScheduleSectorService.CreateAsync(dto);

            if (response.StatusCode == Application.Enums.ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("Creation is Fail.");
        }
    }
}