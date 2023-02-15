using Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using Twilio;
using Twilio.Base;
using Twilio.Rest.Conversations.V1;
//using Twilio.Rest.Conversations.V1.Service.Conversation;
using Twilio.Rest.Conversations.V1.Conversation;
using Twilio.Rest.Conversations.V1.Service.User;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Services
{
    public class ConversationService : IConversationService
    {
        private readonly IConfiguration _configuration;
        public ConversationService(IConfiguration configuration)
        {
            _configuration = configuration;
            Init();
        }

        void Init()
        {
            // and set the environment variables. See http://twil.io/secure
            string accountSid = _configuration["TWILIO:ACCOUNT_SID"];
            string authToken = _configuration["TWILIO:AUTH_TOKEN"];
            TwilioClient.Init(accountSid, authToken);
        }

        #region Conversation
        public async Task<ConversationResource> CreateConversationAsync(TwillioConversation conversation)
        {
            var cons = await ReadConversationsAsync();
            if(cons.Any(x=>x.UniqueName == conversation.UniqueName))
            {
                conversation.UniqueName= string.Format("{0}_{1}{2}{3}",conversation.UniqueName, DateTime.Now.Hour,DateTime.Now.Minute, DateTime.Now.Second);
                conversation.FriendlyName = conversation.UniqueName;
            }               

            return await ConversationResource.CreateAsync(
                friendlyName: conversation.FriendlyName,
                uniqueName: conversation.UniqueName
                );
        }

        public async Task<Twilio.Rest.Conversations.V1.Service.ConversationResource> CreateServiceConversationAsync( string pathChatServiceSid, string? friendlyName = null)
        {
            return await Twilio.Rest.Conversations.V1.Service.ConversationResource.CreateAsync(
            friendlyName: friendlyName,
            pathChatServiceSid: pathChatServiceSid // "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
           );
        }

        public async Task<ResourceSet<ConversationResource>> ReadConversationsAsync()
        {
            return await ConversationResource.ReadAsync();
        }

        public async Task<ResourceSet<ParticipantConversationResource>> ReadParticipantConversationAsync(TwillioParticipant participant, int limit = 20)
        {
            return await ParticipantConversationResource.ReadAsync(
            identity: participant.Identity,
            limit: limit);
        }

        public async Task<ConversationResource> FetchConversationAsync(string pathId)
        {
            return await ConversationResource.FetchAsync(pathId); // pathSid: "CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        }

        public async Task<UserConversationResource> FetchUserConversationAsync(string userId, string pathConversationSid, string pathChatServiceSid)
        {

            var userConversation = await UserConversationResource.FetchAsync(
                pathUserSid: userId, //"USXXXXXXXXXXXXX",
                pathConversationSid: pathConversationSid, //"CHXXXXXXXXXXXXX",
                pathChatServiceSid: pathChatServiceSid // ISXXX
            );

            return userConversation;
        }

        public async Task<ResourceSet<UserConversationResource>> ReadUserConversationAsync(string identity, string pathChatServiceSid, int? limit = null)
        {

            var userConversations = await UserConversationResource.ReadAsync(
                pathUserSid: identity,// "USXXXXXXXXXXXXX",
                pathChatServiceSid: pathChatServiceSid, // ISXXX
                limit: limit
            );

            return userConversations;
        }

        public async Task<ParticipantResource> FetchConversationParticipantAsync(string pathConversationSid, string pathSid)
        {
            var participant = await ParticipantResource.FetchAsync(
                pathConversationSid: pathConversationSid, // "CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                pathSid: pathSid //"MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            );

            return participant;
        }

        public async Task<ResourceSet<ParticipantResource>> ReadConversationParticipantAsync(string pathConversationSid, int? limit = null)
        {
            var participants = await ParticipantResource.ReadAsync(
                pathConversationSid: pathConversationSid,
                limit: limit
            );

            return participants;
        }

        public async Task<ConversationResource> ClosedConversationAsync(TwillioConversation conversation)
        {
            return await ConversationResource.UpdateAsync(
             state: ConversationResource.StateEnum.Inactive,
             pathSid: conversation.Sid
         );
        }

        #endregion Conversation

        #region User
        public async Task<UserResource> CreateUserAsync(TwillioUser user)
        {
            return await UserResource.CreateAsync(identity: user.Identity, friendlyName: user.FriendlyName);
        }

        public async Task<UserResource> UpdateUserAsync(string friendlyName, string roleSid, string pathSid)
        {
            var user = await UserResource.UpdateAsync(
               friendlyName: friendlyName, // "new name",
               roleSid: roleSid, // "RLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
               pathSid: pathSid // "USXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
           );

            return user;
        }

        public async Task<UserResource> FetchUserAsync(string pathId)
        {
            return await UserResource.FetchAsync(pathId); // pathSid: "CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        }

        public async Task<ResourceSet<UserResource>> ReadUserAsync(int limit = 20)
        {
            return await UserResource.ReadAsync(limit: limit);
        }

        #endregion User

        #region Participant
        public async Task<ParticipantResource> CreateParticipantAsync(TwillioParticipant participant)
        {
            return await ParticipantResource.CreateAsync(
                pathConversationSid: participant.PathConversationSid,
                identity: participant.Identity
                );

        }
        #endregion Participant

        #region Messages        
        public async Task<MessageResource> CreateMessageAsync(TwillioMessage message)
        {
            return await MessageResource.CreateAsync(
                author: message.Auther, // identity
                body: message.Body,
                pathConversationSid: message.PathConversationSid
                // attributes: message.Attributes != null ? JsonConvert.SerializeObject(message.Attributes) : null
            );
        }

        public async Task<MessageResource> UpdateMessageAsync(TwillioMessage message)
        {
            return await MessageResource.UpdateAsync(
                author: message.Auther, // identity
                body: message.Body,
                pathConversationSid: message.PathConversationSid,
                pathSid: message.pathSid
            );
        } 
        
        public async Task<bool> DeleteMessageAsync(TwillioMessage message)
        {
            return await MessageResource.DeleteAsync(
                pathConversationSid: message.PathConversationSid,
                pathSid: message.pathSid
            );
        }

        public async Task<ResourceSet<MessageResource>> ReadConversationMessagesAsync(string pathConversationSid, int? limit = null)
        {
            var messages = await MessageResource.ReadAsync(
                pathConversationSid: pathConversationSid,
                limit: limit);
            return messages;
        }

        public async Task<MessageResource> FetchMessagesAsync(string pathConversationSid, string pathSid)
        {
            var message = await MessageResource.FetchAsync(
                pathConversationSid: pathConversationSid, //"CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                pathSid: pathSid // "IMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            );
            return message;
        }

        public async Task<ResourceSet<MessageResource>> ReadMessagesAsync(string pathConversationSid, int? limit = null)
        {
            var messages = await MessageResource.ReadAsync(
                order: MessageResource.OrderTypeEnum.Desc,
                pathConversationSid: pathConversationSid,
                limit: limit
            );
            return messages;
        }

        #endregion Messages

        #region Services
        public async Task<ServiceResource> CreateServiceAsync(string friendlyName) // need a services for each environments.
        {
            return await ServiceResource.CreateAsync(
                friendlyName: friendlyName
            );
        }

        public async Task<bool> DeleteServiceAsync(string sId)
        {
            return await ServiceResource.DeleteAsync(pathSid: sId); // ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        }

       
        #endregion Services

        // TODO: Use facotry method and use enum for diff types (User, Msg, Participant, conversion)
    }
}
