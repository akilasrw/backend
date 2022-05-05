using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Core.Entities;

namespace Aeroclub.Cargo.Application.Extensions
{
    public static class MappingExtension
    {
        public static FlightSchedule MapOriginAirport(this FlightSchedule flightSchedule, Airport originAirport)
        {
            flightSchedule.OriginAirportCode = originAirport.Code;
            flightSchedule.OriginAirportName = originAirport.Name;

            return flightSchedule;
        }
        
        public static FlightSchedule MapDestinationAirport(this FlightSchedule flightSchedule, Airport destinationAirport)
        {
            flightSchedule.DestinationAirportCode = destinationAirport.Code;
            flightSchedule.DestinationAirportName = destinationAirport.Name;

            return flightSchedule;
        }

        public static CargoPosition MapCargoPosition(this CargoPosition position, Guid positionId, Guid seatId)
        {
            position.SeatId = seatId;
            position.Id = positionId;
            return position;
        }
    }
}