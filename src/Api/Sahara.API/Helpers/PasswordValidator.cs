using System.Text.RegularExpressions;

namespace Sahara.API.Helpers
{
    /// <summary>
    /// Provides functionality to validate the strength and format of a password and return the normalized result.
    /// </summary>
    public static class PasswordValidator
    {
        /// <summary>
        /// Validates the specified password based on complexity rules.
        /// </summary>
        /// <param name="password">The password to validate.</param>
        /// <returns>
        /// The trimmed password string if it meets all complexity requirements.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the password fails to meet any of the following criteria:
        /// it must be between 8 and 50 characters in length, and contain at least one special character,
        /// one number, one lowercase letter, and one uppercase letter.
        /// </exception>
        /// <example>
        /// var newPassword = PasswordValidator.Validate("ExamplePassword@123!");
        /// </example>
        public static string Validate(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be empty.", nameof(password));
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
