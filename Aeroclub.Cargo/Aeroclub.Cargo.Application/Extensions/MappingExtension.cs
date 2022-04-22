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
    }
}