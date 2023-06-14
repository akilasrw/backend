using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos.Chatting
{
    public class ChatUserDto
    {
        public string Sid { get; set; }
        public string AccountSid { get; set; }
        public string Identity { get; set; }
        public string FriendlyName { get; set; }
        public Uri Url { get; set; }
    }
}
