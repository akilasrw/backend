using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.SeatConfigurationVM;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{

    public class CargoPositionController : BaseApiController
    {
        private readonly ICargoPositionService _cargoPositionService;
        public CargoPositionController(ICargoPositionService cargoPositionService)
        {
            this._cargoPositionService = cargoPositionService;
        }


        [HttpPost("Validate")]
        public async Task<ActionResult<ValidateResponse>> ValidateAsync([FromBody] ValidateCargoPositionRM rm)
        {
            var res = await _cargoPositionService.ValidateCargoPositionAsync(rm);

            return Ok(res);
        }

        [HttpGet()]
        public async Task<ActionResult<SeatAvailabilityVM>> GetAsync([FromQuery] FlightScheduleSectorQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await _cargoPositionService.GetAvailableThreeSeatAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }



    }
}
