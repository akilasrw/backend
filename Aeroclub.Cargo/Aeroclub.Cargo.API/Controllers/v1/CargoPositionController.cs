using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.DTOs;
using Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoPositionRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoPositionVMs;
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

        [HttpGet("GetSummaryCargoPositions")]
        public async Task<ActionResult<List<CargoPositionVM>>> GetSummeryCargoPositionAsync([FromQuery] CargoPositionsPerFlightScheduleRM query)
        {
            if (query.AircraftLayoutId == Guid.Empty) return BadRequest();

            var result = await _cargoPositionService.GetSummeryCargoPositionAsync(query.AircraftLayoutId);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetSummaryCargoPositionsBySector")]
        public async Task<ActionResult<List<CargoPositionVM>>> GetSummeryCargoPositionBySectorAsync([FromQuery] CargoPositionsBySectorRM query)
        {
            if (query.FlightScheduleSectorId == Guid.Empty) return BadRequest();

            var result = await _cargoPositionService.GetPositionsForFlightScheduleSectorIdAsync(query.FlightScheduleSectorId);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut("UpdateCargoPositionProperties")]
        public async Task<ActionResult> UpdateCargoPositionPropertiesAsync([FromBody] UpdateCargoPositionPropertiesDTO updateDTO)
        {
            if (updateDTO == null || updateDTO.CargoPositionId == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                await _cargoPositionService.UpdateCargoPositionPropertiesAsync(
                    updateDTO.CargoPositionId,
                    updateDTO.NewHeight,
                    updateDTO.NewMaxWeight,
                    updateDTO.NewMaxVolume);

                return Ok(new
                {
                    message = "Successfull updated the record"
                }); 
            }
          
            catch (Exception ex)
            {
               
                return StatusCode(500, ex.Message); 
            }
        }



    }
}
