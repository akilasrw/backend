using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.FlightQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.FlightVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class FlightController : BaseApiController
    {
        private readonly IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }
        
        [HttpGet()]
        public async Task<ActionResult<FlightVM>> GetAsync([FromQuery]FlightQM query)
        {
            return Ok(await _flightService.GetAsync<FlightVM>(query));
        }
        
        [HttpGet("getList")]
        public async Task<ActionResult<IReadOnlyList<FlightVM>>> GetListAsync([FromQuery] FlightListQM query)
        {
            return Ok(await _flightService.GetListAsync<FlightVM>(query));
        }
    }
}