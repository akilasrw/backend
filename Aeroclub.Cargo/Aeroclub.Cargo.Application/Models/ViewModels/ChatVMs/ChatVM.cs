using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.ViewModels.ChatVMs
{
    public class ChatVM
    {        
        public string ChatBody { get; set; } = null!;
        public string? ParticipantEmail { get; set; }
        public string? SId { get; set; }
        public Boolean IsRead { get; set; }
    }
}
