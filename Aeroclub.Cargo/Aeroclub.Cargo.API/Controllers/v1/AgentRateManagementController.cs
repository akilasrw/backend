using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.AgentRateManagementQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AgentRateManagementRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AgentRateManagementVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class AgentRateManagementController : BaseApiController
    {
        private readonly IAgentRateManagementService _agentRateManagementService;
        public AgentRateManagementController(IAgentRateManagementService agentRateManagementService)
        {
            this._agentRateManagementService = agentRateManagementService;
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<IReadOnlyList<AgentRateManagementVM>>> GetAsync([FromQuery] AgentRateManagementQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _agentRateManagementService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetFilteredAgentRateList")]
        public async Task<ActionResult<Pagination<AgentRateManagementVM>>> GetFilteredAgentRateListAsync([FromQuery] AgentRateManagementRateListQM query)
        {
            return Ok(await _agentRateManagementService.GetFilteredAgentRateListAsync(query));
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<AgentRateManagementVM>>> GetFilteredListAsync([FromQuery] AgentRateManagementListQM query)
        {
            return Ok(await _agentRateManagementService.GetFilteredListAsync(query));
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] AgentRateManagementListRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _agentRateManagementService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(new { message = response.Message });

            if (response.StatusCode == ServiceResponseStatus.Success)
                return Ok(new { message = "Rate created successfully." });

            return BadRequest("Rate creation fails.");

        }

        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] AgentRateManagementUpdateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var response = await _agentRateManagementService.UpdateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(new { message = response.Message });

            if (response.StatusCode == ServiceResponseStatus.Failed)
                return BadRequest("Rate update fails.");

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteAsync(Guid id)
        {
            if (Guid.Empty == id)
            {
                return BadRequest();
            }

            var response = await _agentRateManagementService.DeleteAsync(id);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(new { message = response.Message });

            if (response.StatusCode == ServiceResponseStatus.Success)
                return Ok(new { message = "Rate deleted successfully." });

            return BadRequest(new { message = "Rate delete fail." });
        }
    }
}
