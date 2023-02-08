using Aeroclub.Cargo.Application.Models.Dtos.Chatting;
using Aeroclub.Cargo.Application.Models.RequestModels.FlightScheduleSectorRMs;
using Aeroclub.Cargo.Core.Entities;
using System.Security.Policy;

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

        public static CargoPosition MapCargoPosition(this CargoPosition position, Guid positionId, Guid? seatId, Guid? overheadId)
        {
            position.SeatId = seatId;
            position.Id = positionId;
            position.OverheadCompartmentId = overheadId;
            return position;
        }

        public static ChatUserDto MapChatUser(this ChatUserDto user, string sid, string accountSid, string identity, string friendlyName, Uri url)
        {
            user.Sid = sid;
            user.AccountSid = accountSid;
            user.Identity = identity;
            user.FriendlyName = friendlyName;
            user.Url = url;

            return user;
        }
        public static MessageDto MapMessage(this MessageDto message, string pathConversationSid, string body, string auther, string? pathSid =null)
        {
            message.PathConversationSid = pathConversationSid;
            message.Auther = auther;
            message.Body = body;
            message.pathSid = pathSid;

            return message;
        }
        
        
        public static ParticipantDto MapParticipant(this ParticipantDto participant, string sid, string accountSid, string identity)
        {
            participant.Sid = sid;
            participant.Identity = identity;
            //participant.AccountSid = accountSid;
            return participant;
        }
        
        public static ConversationDto MapConversation(this ConversationDto conversation, string sid, string friendlyName, string uniqueName)
        {
            conversation.Sid = sid;
            conversation.FriendlyName = friendlyName;
            conversation.UniqueName = uniqueName;
            return conversation;
        }
    }
}