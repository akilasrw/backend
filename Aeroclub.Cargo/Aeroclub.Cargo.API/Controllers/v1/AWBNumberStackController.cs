using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AWBNumberStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberStackRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBNumberStackVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class AWBNumberStackController : ControllerBase
    {
        private readonly IAWBNumberStackService _AWBNumberStackService;
        public AWBNumberStackController(IAWBNumberStackService aWBNumberStackService)
        {
            this._AWBNumberStackService = aWBNumberStackService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] AWBNumberStackCreateRM rm)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var res = await _AWBNumberStackService.CreateAsync(rm);

            if (res == null) return BadRequest();

            if (res.StatusCode == ServiceResponseStatus.ValidationError) return BadRequest(res.Message);

            return CreatedAtAction(nameof(GetAsync), rm);
        }


        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<AWBNumberStackVM>> GetAsync([FromQuery] AWBNumberStackQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _AWBNumberStackService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] AWBNumberStackUpdateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var res = await _AWBNumberStackService.UpdateAsync(dto);

            if (res == null) return BadRequest();
            if (res.StatusCode == ServiceResponseStatus.ValidationError) return BadRequest(res.Message);

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteAsync(Guid id)
        {
            var awbNumber = await _AWBNumberStackService.GetAsync(new AWBNumberStackQM() { Id = id });

            if (awbNumber == null)return NotFound();
            if(awbNumber.IsUsed) return BadRequest("Unable to delete. It is already used.");

            var result = await _AWBNumberStackService.DeleteAsync(id);
            return Ok(result);
        }

    }
}
