﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Application.Models.Dtos.Chatting
{
    public class MessageDto
    {
        public string? Auther { get; set; }
        public string? Body { get; set; }
        public string? PathConversationSid { get; set; }
        public string? pathSid { get; set; }
        public string? Attributes { get; set; }
    }
}
