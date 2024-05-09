using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Queries.CargoBookingLookupQMs;
using Aeroclub.Cargo.Application.Models.Queries.DeliveryAuditQM;
using Aeroclub.Cargo.Application.Models.Queries.ItemsByDateQM;
using Aeroclub.Cargo.Application.Models.ViewModels.CargoBookingLookupVMs;
using Aeroclub.Cargo.Application.Models.ViewModels.PackageAuditVM;
using Aeroclub.Cargo.Application.Services;
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
        private readonly IPackageItemService _packageItemService;
     
        public CargoBookingLookupController(ICargoBookingLookupService _cargoBookingLookupService, IPackageItemService packageItemService)
        {
            cargoBookingLookupService = _cargoBookingLookupService;
            _packageItemService = packageItemService;
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
        public async Task<ActionResult<DeliveryAudit>> GetDeliveryAudit([FromQuery]DeliveryAuditQM query)
        {
           

            var result = await cargoBookingLookupService.GetDeliveryAudit(query);

            if (result == null)
                return BadRequest("Invalid date range.");

            return Ok(result);
        }

        [HttpGet("ChartData")]
        public async Task<ActionResult<DeliveryAudit>> ChatData([FromQuery] DeliveryAuditQM query)
        {


            var result = await cargoBookingLookupService.GetChartData(query);

            if (result == null)
                return BadRequest("Invalid reference number.");

            return Ok(result);
        }

        [HttpGet("PackageByDate")]
        public async Task<ActionResult<PackageAuditVM>> GetPackagesByDate([FromQuery] ItemsByDateQM query)
        {
            return Ok(await _packageItemService.GetPackagesByDate(query));
        }


    }
}
