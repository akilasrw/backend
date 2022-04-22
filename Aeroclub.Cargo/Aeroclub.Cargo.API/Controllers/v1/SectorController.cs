using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.SectorQMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class SectorController : BaseApiController
    {
        private readonly ISectorService _sectorService;

        public SectorController(ISectorService sectorService)
        {
            _sectorService = sectorService;
        }
        
        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody] SectorDto model)
        {
            if (!ModelState.IsValid) return BadRequest("Some fields are missing");
            await _sectorService.CreateAsync(model);
            return Ok();
        }

        [HttpGet()]
        public async Task<ActionResult<SectorDto>> GetAsync([FromQuery] SectorQM query)
        {
            return Ok(await _sectorService.GetAsync(query));
        }
    }
}