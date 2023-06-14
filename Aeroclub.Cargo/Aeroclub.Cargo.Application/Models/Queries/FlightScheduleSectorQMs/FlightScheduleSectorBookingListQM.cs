using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Queries.FlightScheduleSectorQMs
{
    public class FlightScheduleSectorBookingListQM
    {
        public string? FlightNumber { get; set; } = null;
        public string? BookingNumber { get; set; } = null;
        public Guid? AgentId { get; set; } = null;
        public DateTime FlightDate { get; set; } = DateTime.MinValue;
        public StandByStatus StandByStatus { get; set; } = StandByStatus.None;
    }

    public class FlightScheduleSectorVerifyBookingListQM: BaseQM
    {
        public Guid FlightScheduleId { get; set; }
    }
    public class FlightScheduleSectorMobileQM
    {
        public long? AWBTrackingNumber { get; set; }
    }

}
