using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos.Chatting
{
    public class ConversationDto
    {
        public string? Sid { get; set; }
        public string? FriendlyName { get; set; }
        public string? UniqueName { get; set; }
    }
}
