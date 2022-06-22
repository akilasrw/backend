using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SectorRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SectorVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class SectorController : BaseApiController
    {
        private readonly ISectorService _sectorService;

        public SectorController(ISectorService sectorService)
        {
            _sectorService = sectorService;
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] SectorCreateRM model)
        {
            if (!ModelState.IsValid)return BadRequest(ModelState);

            var response = await _sectorService.CreateAsync(model);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest("Given sector is already available in the system.");
            
            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, model);

            return BadRequest("Sector creation fails.");
        }

        [HttpGet()]
        public async Task<ActionResult<SectorVM>> GetAsync([FromQuery] SectorQM query)
        {
            return Ok(await _sectorService.GetAsync(query));
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<SectorVM>>> GetFilteredListAsync([FromQuery] SectorListQM query)
        {
            return Ok(await _sectorService.GetFilteredListAsync(query));
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] SectorUpdateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response = await _sectorService.UpdateAsync(dto);
            if(response == ServiceResponseStatus.ValidationError)
                return BadRequest("Given sector is already available in the system.");
           
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteAsync(Guid id)
        {
            var airport = await _sectorService.GetAsync(new SectorQM() { Id = id });
            if (airport == null)
            {
                return NotFound();
            }

            var result = await _sectorService.DeleteAsync(id);
            return Ok(result);
        }
    }
}