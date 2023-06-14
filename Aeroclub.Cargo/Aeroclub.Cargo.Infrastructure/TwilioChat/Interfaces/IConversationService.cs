﻿using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Base;
using Twilio.Rest.Conversations.V1;
//using Twilio.Rest.Conversations.V1.Conversation;
using Twilio.Rest.Conversations.V1.Service.Conversation;
using Twilio.Rest.Conversations.V1.Service.User;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces
{
    public interface IConversationService
    {
        Task<ConversationResource> CreateConversationAsync(TwillioConversation conversation);
        Task<ResourceSet<ConversationResource>> ReadConversationsAsync();

        Task<ResourceSet<ParticipantConversationResource>> ReadParticipantConversationAsync(TwillioParticipant participant, int limit = 20);

        Task<ConversationResource> FetchConversationAsync(string pathId);

        Task<UserConversationResource> FetchUserConversationAsync(string userId, string pathConversationSid);

        Task<ResourceSet<UserConversationResource>> ReadUserConversationAsync(string identity, int? limit = null);

        Task<ParticipantResource> FetchConversationParticipantAsync(string pathConversationSid, string pathSid);

        Task<ResourceSet<ParticipantResource>> ReadConversationParticipantAsync(string pathConversationSid, int? limit = null);

        Task<ConversationResource> ClosedConversationAsync(TwillioConversation conversation);

        Task<UserResource> CreateUserAsync(TwillioUser user);

        Task<Twilio.Rest.Conversations.V1.Service.UserResource> CreateServiceUserAsync(TwillioUser user);

        Task<UserResource> UpdateUserAsync(string friendlyName, string roleSid, string pathSid);

        Task<UserResource> FetchUserAsync(string pathId);

        Task<ResourceSet<UserResource>> ReadUserAsync(int limit = 20);

        Task<ResourceSet<Twilio.Rest.Conversations.V1.Service.UserResource>> ReadUserServicesAsync(int limit = 20);

        Task<ParticipantResource> CreateParticipantAsync(TwillioParticipant participant);

        Task<MessageResource> CreateMessageAsync(TwillioMessage message);

        Task<MessageResource> UpdateMessageAsync(TwillioMessage message);

        Task<bool> DeleteMessageAsync(TwillioMessage message);

        Task<ResourceSet<MessageResource>> ReadMessagesAsync(string pathConversationSid, int? limit = null);

        Task<MessageResource> FetchMessagesAsync(string pathConversationSid, string pathSid);

        Task<Twilio.Rest.Conversations.V1.Service.ConversationResource> CreateServiceConversationAsync(TwillioConversation conversation);

        Task<ServiceResource> CreateServiceAsync(string friendlyName);

        Task<bool> DeleteServiceAsync(string sId);

        Task<ServiceResource> FetchServiceAsync(string pathSid);

    }
}
