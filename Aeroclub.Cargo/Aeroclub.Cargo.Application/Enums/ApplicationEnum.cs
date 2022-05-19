using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Enums
{
    public enum ServiceResponseStatus
    {
        Success = 0,
        ValidationError   = 1,
        Failed   = 2,
        
    }


    public enum BookingServiceResponseStatus
    {
        Success = 0,
        ValidationError = 1,
        Failed = 2,
        NoSpace = 3,

    }
}
