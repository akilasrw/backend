using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Models
{
    public class TwillioParticipant :TwillioBaseModel
    {
        public string? PathConversationSid { get; set; }
        public string? Identity { get; set; }
    }
}
