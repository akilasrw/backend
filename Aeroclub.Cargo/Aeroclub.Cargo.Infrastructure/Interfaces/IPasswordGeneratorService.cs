using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace Aeroclub.Cargo.Infrastructure.Interfaces
{
    public interface IPasswordGeneratorService
    {
        int PasswordSize { get; set; }
        string GeneratePasswordStrongPassword();
       
    }
}
