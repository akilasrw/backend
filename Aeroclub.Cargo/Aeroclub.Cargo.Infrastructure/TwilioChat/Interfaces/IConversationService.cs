using Aeroclub.Cargo.Infrastructure.TwilioChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Conversations.V1;
using Twilio.Rest.Conversations.V1.Conversation;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Interfaces
{
    public interface IConversationService
    {
        Task<ConversationResource> CreateConversationAsync(TwillioConversation conversation);
        Task<ConversationResource> ClosedConversationAsync(TwillioConversation conversation);

        Task<UserResource> CreateUserAsync(TwillioUser user);

        Task<ParticipantResource> CreateParticipantAsync(TwillioParticipant participant);

        Task<MessageResource> CreateMessageAsync(TwillioMessage message);


    }
}
