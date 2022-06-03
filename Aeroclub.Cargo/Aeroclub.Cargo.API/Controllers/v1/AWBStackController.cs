using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AWBStackQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AWBNumberRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AWBStackVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class AWBStackController : BaseApiController
    {
        private readonly IAWBStackService _AWBStackService;
        public AWBStackController(IAWBStackService AWBStackService)
        {
            _AWBStackService = AWBStackService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] AWBStackRM rm)
        {
            var res = await _AWBStackService.CreateAsync(rm);

            if (res == null) return BadRequest();

            if (res.StatusCode == ServiceResponseStatus.ValidationError) return BadRequest("Invalid sequence number.");

            return CreatedAtAction(nameof(GetAsync), rm);
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<AWBStackVM>> GetAsync([FromQuery] AWBStackQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _AWBStackService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<AWBStackVM>>> GetFilteredListAsync([FromQuery] AWBStackListQM query)
        {
            return Ok(await _AWBStackService.GetBookingFilteredListAsync(query));
        }

        [HttpGet("GetLastRecord")]
        public async Task<ActionResult<AWBStackVM>> GetLastRecordAsync()
        {
            var result = await _AWBStackService.GetLastRecordAsync();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        


    }
}
