using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.MasterScheduleQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.MasterScheduleRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.MasterScheduleVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class MasterScheduleController : BaseApiController
    {
        private readonly IMasterScheduleService _masterScheduleService;
        public MasterScheduleController(IMasterScheduleService masterScheduleService)
        {
            _masterScheduleService = masterScheduleService;
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<MasterScheduleVM>> GetAsync([FromQuery] MasterScheduleDetailQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _masterScheduleService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] MasterScheduleRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _masterScheduleService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message == null ? "Validation fails." : response.Message);

            return BadRequest(response.Message == null ? "Schedule creation fails." : response.Message);
        }








    }
}
