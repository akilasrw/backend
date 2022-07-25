using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AircraftRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{

    [ApiVersion("1.0")]
    [Authorize]
    public class AircraftController : BaseApiController
    {
        private readonly IAircraftService _aircraftService;

        public AircraftController(IAircraftService aircraftService)
        {
            this._aircraftService = aircraftService;

        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<IReadOnlyList<AircraftVM>>> GetAsync([FromQuery] AircraftQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _aircraftService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }


        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<AircraftVM>>> GetFilteredListAsync([FromQuery] AircraftListQM query)
        {
            return Ok(await _aircraftService.GetFilteredListAsync(query));
        }

        [HttpGet("GetAircraftTypes")]
        public async Task<ActionResult<IReadOnlyList<AircraftTypeVM>>> GetAircraftTypesAsync([FromQuery] AircraftTypeQM query)
        {
            return Ok(await _aircraftService.GetAircraftTypesAsync(query));
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] AircaftCreateRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _aircraftService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest("Reg number is already used in the system.");

            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("Aircraft creation fails.");

        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] AircaftUpdateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response =  await _aircraftService.UpdateAsync(dto);

            if (response == ServiceResponseStatus.ValidationError)
                return BadRequest("Registration number unable to edit.");

            if (response == ServiceResponseStatus.Failed)
                return BadRequest("Aircraft update fails.");

            return NoContent();
        }

    }
}
