using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Extensions;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AirportQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirportRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class AirportController : BaseApiController
    {
        private readonly IAirportService _airportService;

        public AirportController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        [HttpGet("getSelectList")]
        public async Task<ActionResult<IReadOnlyList<BaseSelectListModel>>> GetSelectListAsync()
        {
            return Ok(await _airportService.GetSelectListAsync());
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<AirportVM>>> GetFilteredListAsync([FromQuery] AirportListQM query)
        {
            return Ok(await _airportService.GetFilteredListAsync(query));
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<IReadOnlyList<AirportVM>>> GetAsync([FromQuery] AirportQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _airportService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AirportCreateRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _airportService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("Airport creation fails.");
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] AirportUpdateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response = await _airportService.UpdateAsync(dto);

            if (response == ServiceResponseStatus.ValidationError)
                return BadRequest("Airport already available.");

            if (response == ServiceResponseStatus.Failed)
                return BadRequest("Airport update fails.");

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteAsync(Guid id)
        {
            var airport = await _airportService.GetAsync(new AirportQM() { Id = id });
            if (airport == null)
            {
                return NotFound();
            }

            var result = await _airportService.DeleteAsync(id);
            return Ok(result);
        }

    }
}