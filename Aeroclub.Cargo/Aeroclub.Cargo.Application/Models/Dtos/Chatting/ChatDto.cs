using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos.Chatting
{
    public class ChatDto
    {
        public string ChatBody { get; set; } = null!;
        public string? ParticipantEmail { get; set; }
        public string? SId { get; set; }
        public bool IsRead { get; set; }
        public bool? IsExistedUser { get; set; }
    }
}
