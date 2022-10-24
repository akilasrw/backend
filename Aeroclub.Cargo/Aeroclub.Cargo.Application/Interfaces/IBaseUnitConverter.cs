using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface IBaseUnitConverter
    {
        Task<double> VolumeCalculatorAsync(double value, Guid volumeUnitId);
    }
}
