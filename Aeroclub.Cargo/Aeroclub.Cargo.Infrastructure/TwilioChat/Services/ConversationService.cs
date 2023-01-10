using Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces;
using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using Microsoft.Extensions.Configuration;
using Twilio;
using Twilio.Base;
using Twilio.Rest.Conversations.V1;
using Twilio.Rest.Conversations.V1.Conversation;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Services
{
    public class ConversationService: IConversationService
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

        public async Task<ConversationResource> CreateConversationAsync(TwillioConversation conversation)
        {
            return await ConversationResource.CreateAsync(
                friendlyName: conversation.FriendlyName,
                uniqueName: conversation.UniqueName
                );
        } 
        
        public async Task<UserResource> CreateUserAsync(TwillioUser user)
        {
            return await UserResource.CreateAsync(identity: user.Identity);
        } 
        
        public async Task<ParticipantResource> CreateParticipantAsync(TwillioParticipant participant)
        {
            return await ParticipantResource.CreateAsync(
                pathConversationSid: participant.PathConversationSid,
                identity:participant.Identity
                );
        } 

        public async Task<MessageResource> CreateMessageAsync(TwillioMessage message)
        {
            return await MessageResource.CreateAsync(
                author: message.Auther,
                body:message.Body,
                pathConversationSid: message.PathConversationSid
            );
        }

        public async Task<ConversationResource> ClosedConversationAsync(TwillioConversation conversation)
        {
            return await ConversationResource.UpdateAsync(
             state: ConversationResource.StateEnum.Inactive,
             pathSid: conversation.Sid
         );
        }

        public async Task<ResourceSet<ParticipantConversationResource>> ReadParticipantConversationAsync(TwillioParticipant participant)
        {
            return await ParticipantConversationResource.ReadAsync(
            identity: participant.Identity,
            limit: 20
        );
        }
    }
}
