using Aeroclub.Cargo.Infrastructure.Models;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Interfaces
{
    public interface IEmailSenderService
    {
        Task<Response> SendEmailAsync(EmailRequest request);
    }
}
