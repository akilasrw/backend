using Aeroclub.Cargo.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.Services
{
    public class PasswordGeneratorService: IPasswordGeneratorService
    {
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";
        const string SPECIALS = @"!@£$%^&*()#€";

        public int PasswordSize { get; set; } = 8;

        public string GeneratePasswordStrongPassword()
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            string password = "";
            // Generated password until making sure all combinations are including.
            while (!(password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper) && !regexItem.IsMatch(password)))
                password = GeneratePassword();

            return password;
        }

        private string GeneratePassword(bool useLowercase = true, bool useUppercase = true, bool useNumbers = true, bool useSpecial = true)
        {
            char[] _password = new char[PasswordSize];
            string charSet = ""; // Initialise to blank
            Random _random = new Random();
            int counter;

            // Build up the character set to choose from
            if (useLowercase) charSet += LOWER_CASE;

            if (useUppercase) charSet += UPPER_CAES;

            if (useNumbers) charSet += NUMBERS;

            if (useSpecial) charSet += SPECIALS;

            for (counter = 0; counter < PasswordSize; counter++)
            {
                _password[counter] = charSet[_random.Next(charSet.Length - 1)];
            }

            return string.Join(null, _password);
        }
    }
}
