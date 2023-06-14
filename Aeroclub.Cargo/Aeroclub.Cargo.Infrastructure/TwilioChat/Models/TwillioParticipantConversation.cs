using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Models
{
    public class TwillioParticipantConversation
    {
        public string? ChatServiceSid { get; set; }
        public string? ParticipantIdentity	{ get; set; }
        public string? ConversationSid	{ get; set; }
        public string? ParticipantSid { get; set; }
        public string? ParticipantUserSid { get; set; }
        public string? ConversationCreatedBy { get; set; }
        public DateTime? ConversationDateCreated { get; set; }
    }
}

