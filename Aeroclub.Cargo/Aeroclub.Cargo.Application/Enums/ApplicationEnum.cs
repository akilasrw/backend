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

    public enum AircaftAssignedStatus
    {
        None =0,
        Pending = 1,
        PartiallyCompleted = 2,
        Completed = 3
    }

    public enum FlightScheduleReportType
    {
        None = 0,
        Idle = 1,
        Running = 2
    }

    public enum NotificationFilterType
    {
        None = 0,
        All = 1,
        Read = 2,
        UnRead = 3,
    }
}
