using Aeroclub.Cargo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface ILayoutCloneService
    {
        Task CloneLayoutAsync(FlightSchedule flightSchedule);
    }
}
