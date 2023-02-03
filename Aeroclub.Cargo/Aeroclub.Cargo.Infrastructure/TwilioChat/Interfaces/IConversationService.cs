using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Base;
using Twilio.Rest.Conversations.V1;
using Twilio.Rest.Conversations.V1.Conversation;
using Twilio.Rest.Conversations.V1.Service.User;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces
{
    public interface IConversationService
    {
        Task<ConversationResource> CreateConversationAsync(TwillioConversation conversation);

        Task<ResourceSet<ParticipantConversationResource>> ReadParticipantConversationAsync(TwillioParticipant participant, int limit = 20);

        Task<ConversationResource> FetchConversationAsync(string pathId);

        Task<UserConversationResource> FetchUserConversationAsync(string userId, string pathConversationSid, string pathChatServiceSid);

        Task<ResourceSet<UserConversationResource>> ReadUserConversationAsync(string userId, string pathChatServiceSid, int? limit = null);

        Task<ParticipantResource> FetchConversationParticipantAsync(string pathConversationSid, string pathSid);

        Task<ResourceSet<ParticipantResource>> ReadConversationParticipantAsync(string pathConversationSid, int? limit = null);

        Task<ConversationResource> ClosedConversationAsync(TwillioConversation conversation);

        Task<UserResource> CreateUserAsync(TwillioUser user);

        Task<UserResource> UpdateUserAsync(string friendlyName, string roleSid, string pathSid);

        Task<UserResource> FetchUserAsync(string pathId);

        Task<ResourceSet<UserResource>> ReadUserAsync(int limit = 20);

        Task<ParticipantResource> CreateParticipantAsync(TwillioParticipant participant);

        Task<MessageResource> CreateMessageAsync(TwillioMessage message);

        Task<MessageResource> UpdateMessageAsync(TwillioMessage message);

        Task<bool> DeleteMessageAsync(TwillioMessage message);

        Task<ResourceSet<MessageResource>> ReadMessagesAsync(string pathConversationSid, int? limit = null);

        Task<MessageResource> FetchMessagesAsync(string pathConversationSid, string pathSid);
    }
}
