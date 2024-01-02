﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.TwilioChat.Models
{
    public class TwillioConversation : TwillioBaseModel
    {
        public string? FriendlyName { get; set; }
        public string? UniqueName { get; set; }

    }
}