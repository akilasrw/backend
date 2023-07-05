using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Models
{
    public class EmailRequest
    {
        public string ToMail { get; set; } = null!;
        public string ToName { get; set; } = null!;
        public string Body { get; set; }
        public string HtmlBody { get; set; }
        public string Subject { get; set; } = null!;
    }
}
