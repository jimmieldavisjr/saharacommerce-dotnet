using System.Text.RegularExpressions;

namespace Sahara.API.Helpers
{
    public static class PasswordValidator
    {
        public static string IsValidPassword(string newPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                throw new ArgumentException("Password cannot be empty or have spaces.", nameof(newPassword));
            }

            newPassword = newPassword.Trim();

            if (newPassword.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters", nameof(newPassword));
            }

            if (newPassword.Length > 50)
            {
                throw new ArgumentException("Password must be less than 50 characters", nameof(newPassword));
            }

            if (!Regex.IsMatch(newPassword, @"\W"))
            {
                throw new ArgumentException("Password must contain at least one special character.", nameof(newPassword));
            }

            if (!Regex.IsMatch(newPassword, @"\d"))
            {
                throw new ArgumentException("Password must contain at least one number (0-9)", nameof(newPassword));
            }

            if (!Regex.IsMatch(newPassword, @"[a-z]"))
            {
                throw new ArgumentException("Password must contain at least one lowercase letter", nameof(newPassword));
            }

            if (!Regex.IsMatch(newPassword, @"[A-Z]"))
            {
                throw new ArgumentException("Password must contain at least one uppercase letter", nameof(newPassword));
            }

            return newPassword;
        }
    }
}
