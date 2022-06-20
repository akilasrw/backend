using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AirWayBillQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirWayBillRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class AWBController : BaseApiController
    {
        private readonly IAWBService _awbService;
        public AWBController(IAWBService awbService)
        {
            this._awbService = awbService;

        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<AWBInformationVM>> GetAsync([FromQuery] AirWayBillQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _awbService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] AWBCreateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            dto.IsUpdatePackage = true;

            var response = await _awbService.CreateAsync(dto);

            if (response.StatusCode == Application.Enums.ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("AWB creation fail.");
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] AWBUpdateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _awbService.UpdateAsync(dto);

            return NoContent();
        }

    }
}
