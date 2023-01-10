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
    }
}
