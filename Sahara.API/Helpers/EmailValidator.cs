using Sahara.API.Models;
using System.Net.Mail;

namespace Sahara.API.Helpers
{
    public static class EmailValidator
    {
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
