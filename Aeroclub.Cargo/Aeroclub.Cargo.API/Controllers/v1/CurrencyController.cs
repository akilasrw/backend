using System.Collections.Generic;
using System.Threading.Tasks;
using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Application.Models.Core;
using Microsoft.AspNetCore.Mvc;

namespace Aeroclub.Cargo.API.Controllers.v1
{
    public class CurrencyController : BaseApiController
    {

        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        [HttpGet("getSelectList")]
        public async Task<ActionResult<IReadOnlyList<BaseSelectListModel>>> GetSelectListAsync()
        {
            return Ok(await _currencyService.GetSelectListAsync());
        }


    }
}
