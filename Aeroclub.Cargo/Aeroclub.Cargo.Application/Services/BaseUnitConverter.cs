using Aeroclub.Cargo.Application.Interfaces;
using Aeroclub.Cargo.Common.Extentions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Services
{
    public class BaseUnitConverter: IBaseUnitConverter
    {
        private readonly IConfiguration _configuration;
        public BaseUnitConverter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<double> VolumeCalculatorAsync(double value, Guid volumeUnitId)
        {
            var cmVolumeUnitId = _configuration["BaseUnit:BaseVolumeUnitId"];
            if (volumeUnitId != Guid.Empty && cmVolumeUnitId.ToLower() != volumeUnitId.ToString())
            {
                var inchVolumeUnitId = _configuration["VolumeUnit:InchVolumeUnitId"];
                var meterVolumeUnitId = _configuration["VolumeUnit:MeterVolumeUnitId"];

                if (meterVolumeUnitId.ToLower() == volumeUnitId.ToString())
                {
                    value = value.MeterToCmConversion();
                }

                if (inchVolumeUnitId.ToLower() == volumeUnitId.ToString())
                {
                    value = value.InchToCmConversion();
                }
            }
            return value;
        }
    }
}
