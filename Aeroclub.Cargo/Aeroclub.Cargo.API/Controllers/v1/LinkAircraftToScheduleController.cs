using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleManagementRMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class LinkAircraftToScheduleController : BaseApiController
    {
        private readonly ILinkAircraftToScheduleService _linkAircraftToScheduleService;

        public LinkAircraftToScheduleController(ILinkAircraftToScheduleService linkAircraftToScheduleService)
        {
            _linkAircraftToScheduleService = linkAircraftToScheduleService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ScheduleAircraftRM query)
        {
            return Ok(await _linkAircraftToScheduleService.CreateAsync(query));
        }
    }
}
