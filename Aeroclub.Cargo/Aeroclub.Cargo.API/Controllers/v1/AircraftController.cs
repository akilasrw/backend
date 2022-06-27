using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.AircraftQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.AircraftVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{

    [ApiVersion("1.0")]
    [Authorize]
    public class AircraftController : BaseApiController
    {
        private readonly IAircraftService _aircraftService;

        public AircraftController(IAircraftService aircraftService)
        {
            this._aircraftService = aircraftService;

        }

        [HttpGet("GetAircraftTypes")]
        public async Task<ActionResult<IReadOnlyList<AircraftTypeVM>>> GetAircraftTypesAsync([FromQuery] AircraftTypeQM query)
        {
            return Ok(await _aircraftService.GetAircraftTypesAsync(query));
        }

    }
}
