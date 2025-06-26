using System.Text.RegularExpressions;

namespace Sahara.API.Helpers
{
    public static class PasswordValidator
    {
        public static string Validate(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be empty or have spaces.", nameof(password));
            }

            password = password.Trim();

            if (password.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters", nameof(password));
            }

            if (password.Length > 50)
            {
                throw new ArgumentException("Password must be less than 50 characters", nameof(password));
            }

            if (!Regex.IsMatch(password, @"\W"))
            {
                throw new ArgumentException("Password must contain at least one special character.", nameof(password));
            }

            if (!Regex.IsMatch(password, @"\d"))
            {
                throw new ArgumentException("Password must contain at least one number (0-9)", nameof(password));
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                throw new ArgumentException("Password must contain at least one lowercase letter", nameof(password));
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                throw new ArgumentException("Password must contain at least one uppercase letter", nameof(password));
            }

            return password;
        }
    }
}
