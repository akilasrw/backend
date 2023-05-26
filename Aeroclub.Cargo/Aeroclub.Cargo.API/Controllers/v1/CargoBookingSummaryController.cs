using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Dtos;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingSummaryQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingSummaryVMs;
using Aeroclub.Cargo.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class CargoBookingSummaryController : BaseApiController
    {
        private readonly ICargoBookingSummaryService _cargoBookingSummaryService;

        public CargoBookingSummaryController(ICargoBookingSummaryService cargoBookingSummaryService)
        {
            _cargoBookingSummaryService = cargoBookingSummaryService;
        }

        
        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<CargoBookingSummaryDetailVM>> GetAsync([FromQuery] CargoBookingSummaryDetailQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _cargoBookingSummaryService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }


        [HttpGet("GetFilteredList")]
        public async Task<ActionResult<Pagination<CargoBookingSummaryVM>>> GetFilteredListAsync([FromQuery] CargoBookingSummaryFilteredListQM query)
        {
            return Ok(await _cargoBookingSummaryService.GetFilteredListAsync(query));
        }
    }
}
