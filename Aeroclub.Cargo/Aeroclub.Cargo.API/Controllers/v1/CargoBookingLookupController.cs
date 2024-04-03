using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs;
using Aeroclub.Cargo.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class CargoBookingLookupController : BaseApiController
    {
        private readonly ICargoBookingLookupService cargoBookingLookupService;

        public CargoBookingLookupController(ICargoBookingLookupService _cargoBookingLookupService)
        {
            cargoBookingLookupService = _cargoBookingLookupService;
        }


        [HttpGet]
        public async Task<ActionResult<CargoBookingLookupVM>> GetAsync([FromQuery]CargoBookingLookupQM query)
        {
            if (string.IsNullOrEmpty(query.ReferenceNumber) && query.AWBNumber == null)
                return BadRequest("Please enter booking number or package number.");

            var result = await cargoBookingLookupService.GetAsync(query);

            if (result == null)
                return BadRequest("Invalid reference number.");

            return Ok(result);
        }

        [HttpGet("DelirveryAudit")]
        public async Task<ActionResult<DeliveryAudit>> GetDeliveryAudit()
        {
           

            var result = await cargoBookingLookupService.GetDeliveryAudit();

            if (result == null)
                return BadRequest("Invalid reference number.");

            return Ok(result);
        }


    }
}
