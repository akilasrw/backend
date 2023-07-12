using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs;
using Aeroclub.Cargo.Application.Models.Queries.SystemUserQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.AirportRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs;
using Aeroclub.Cargo.Application.Models.RequestModels.SystemUserRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SystemUserVMs;
using Aeroclub.Cargo.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ManageUserController : BaseApiController        
    {
        private readonly IManageUserService _manageUserService;

        public ManageUserController(IManageUserService manageUserService)
        {
            _manageUserService = manageUserService;
        }

        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<SystemUserVM>> GetAsync([FromQuery] SystemUserQM query)
        {
            if (query.AppUserId == Guid.Empty && query.Id == Guid.Empty) return BadRequest();

            var result = await _manageUserService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] SystemUserCreateRM dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _manageUserService.CreateAsync(dto);

            if (response.StatusCode == ServiceResponseStatus.ValidationError)
                return BadRequest(response.Message);

            if (response.StatusCode == ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest(response.Message);
        }

        [HttpPut("StatusUpdate")]
        public async Task<IActionResult> StatusUpdateAsync([FromBody] SystemUserStatusUpdateRM model)
        {
            if (!ModelState.IsValid) return BadRequest("Some fields are missing.");
            if (model.Id == Guid.Empty) return BadRequest("Id required.");

            await _manageUserService.StatusUpdateAsync(model);

            return NoContent();
        }

        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<SystemUserVM>>> GetFilteredListAsync([FromQuery] SystemUserListQM query)
        {
            return Ok(await _manageUserService.GetFilteredListAsync(query));
        }
    }
}
