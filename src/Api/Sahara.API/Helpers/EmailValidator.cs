using System.Net.Mail;

namespace Sahara.API.Helpers
{
    /// <summary>
    /// Provides functionality to validate the format of an email address and return the normalized result.
    /// </summary>
    public static class EmailValidator
    {
        /// <summary>
        /// Validates the format of an email address and returns a normalized version.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>A normalized email address in lowercase, if the input is valid.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when email format is empty, not properly formatted, or not normalized.
        /// </exception>
        /// <example>
        /// var newEmail = EmailValidator.Validate("example@domain.com");
        /// </example>
        public static string Validate(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Email address cannot be empty", nameof(email));
            }

            email = email.Trim().ToLowerInvariant();

            try
            {
                var mailAddress = new MailAddress(email);

                if (mailAddress.Address == email)
                {
                    return mailAddress.Address;
                }

                else
                {
                    throw new ArgumentException("Email address is not normalized.", nameof(email));
                }
            }

            catch
            {
                throw new ArgumentException("Email address format is invalid.", nameof(email));
            }
        }
    }
}
