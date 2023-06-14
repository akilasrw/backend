using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Models
{
    public class TwillioUser : TwillioBaseModel
    {
        public string? Identity { get; set; }
        public string? ChatServiceSid { get; set; }
        public string? FriendlyName { get; set; }
    }
}
