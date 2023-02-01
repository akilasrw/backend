using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos.Chatting
{
    public class ParticipantDto
    {
        public string Sid { get;  set; }
        public string Identity { get;  set; }
        public string ConversationSid { get; set; }
        public string AccountSid { get; set; }
    }
}
