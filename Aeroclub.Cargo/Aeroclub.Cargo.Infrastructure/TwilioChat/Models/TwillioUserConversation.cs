using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Twilio.Rest.Conversations.V1.ConversationResource;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Models
{
    public class TwillioUserConversation
    {
        public string? ChatServiceSid { get;  set; }
        
        public string? ConversationSid { get;  set; }
        
        public string? ParticipantSid { get;  set; }

        public string? UserSid { get;  set; }

        public string? FriendlyName { get;  set; }
  
        public string? CreatedBy { get;  set; }
        public DateTime? Created { get;  set; }
        public string? UniqueName { get;  set; }
    }
}
