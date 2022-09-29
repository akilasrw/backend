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

            if (response.StatusCode == ServiceResponseStatus.Success)
                return Ok(new { message = "Rate created successfully." });

            return BadRequest("Rate creation fails.");

        }
    }
}
