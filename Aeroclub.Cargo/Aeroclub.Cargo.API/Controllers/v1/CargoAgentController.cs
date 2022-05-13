using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoAgentQMs;
using Aeroclub.Cargo.Application.Models.RequestModels.CargoAgentRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoAgentVMs;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CargoAgentController : BaseApiController
    {
        private readonly ICargoAgentService cargoAgentService;
        public CargoAgentController(ICargoAgentService _cargoAgentService)
        {
            this.cargoAgentService = _cargoAgentService;
        }


        [HttpPost()]
        public async Task<IActionResult> CreateAsync([FromBody]CargoAgentCreateRM dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if(dto.Password != dto.ConfirmPassword) return BadRequest("The password confirmation does not match.");

            if (dto.Password.Length < 8) return BadRequest("The password length must be eight characters.");


            var response = await cargoAgentService.CreateAsync(dto);

            if (response.StatusCode == Application.Enums.ServiceResponseStatus.Success)
                return CreatedAtAction(nameof(GetAsync), new { id = response.Id }, dto);

            return BadRequest("Cargo agent creation fail");
        }


        [HttpPut()]
        public async Task<IActionResult> UpdateAsync([FromBody] CargoAgentUpdateRM model)
        {
            if (!ModelState.IsValid) return BadRequest("Some fields are missing");

            await cargoAgentService.UpdateAsync(model);

            return NoContent();
        }


        [HttpGet()]
        [ActionName(nameof(GetAsync))]
        public async Task<ActionResult<CargoAgentVM>> GetAsync([FromQuery] CargoAgentQM query)
        {
            if (query.Id == Guid.Empty) return BadRequest();

            var result = await cargoAgentService.GetAsync(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteAsync(Guid id)
        {
            if (id == Guid.Empty) return BadRequest();

            return Ok(await cargoAgentService.DeleteAsync(id));
        }

    }
}
