using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Models
{
    public class TwillioMessage: TwillioBaseModel
    {
        public string? Auther { get; set; }
        public string? Body { get; set; }
        public string? PathConversationSid { get; set; }
        public string? pathSid { get; set; }
    }
}
