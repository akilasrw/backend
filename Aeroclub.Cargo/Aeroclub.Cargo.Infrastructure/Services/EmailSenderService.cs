using Aeroclub.Cargo.Infrastructure.Interfaces;
using Aeroclub.Cargo.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Services
{
    public class EmailSenderService: IEmailSenderService
    {
        private readonly IConfiguration _configuration;

        public EmailSenderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Response> SendEmailAsync(EmailRequest request)
        {
            var apiKey = _configuration["SendGrid:ApiKey"];
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress(_configuration["SendGrid:FromEmail"]);
            var to = new EmailAddress(request.ToMail, request.ToName);
            var subject = request.Subject;
            var plainTextContent = request.Body;
            var htmlContent = request.HtmlBody;

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            return await client.SendEmailAsync(msg).ConfigureAwait(false);
        }
    }
}
