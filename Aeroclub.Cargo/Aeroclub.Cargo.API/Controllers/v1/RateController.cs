using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.RateQMs;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.RateVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class RateController : BaseApiController
    {
        private readonly IRateService _rateService;
        private readonly ISectorService _sectorService;
        public RateController(IRateService rateSerice,ISectorService sectorService)
        {
            _rateService = rateSerice;
            _sectorService = sectorService;
        }

        [HttpGet("GetFilteredList")]
        public  async Task<ActionResult<Pagination<RateVM>>> GetFilteredListAsync([FromQuery] RateSectorQM query)
        {
            if (query.DestinationAirportId == Guid.Empty || query.OriginAirportId == Guid.Empty)
                return BadRequest();

            var secterQuery = new SectorQM();
            secterQuery.DestinationAirportId = query.DestinationAirportId;
            secterQuery.OriginAirportId = query.OriginAirportId;

            var sector = await _sectorService.GetAsync(secterQuery);

            if (sector == null) return BadRequest("Sector not available");

            query.SectorId = sector.Id;

            var result = await _rateService.GetFilteredListAsync(query);


            return Ok(result);
        }

    }
}
