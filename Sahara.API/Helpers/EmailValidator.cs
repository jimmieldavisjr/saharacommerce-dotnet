using System.Net.Mail;

namespace Sahara.API.Helpers
{
    public static class EmailValidator
    {
        public static bool IsValidEmailFormat(string newEmail)
        {
            if (string.IsNullOrWhiteSpace(newEmail))
            {
                throw new ArgumentException("Email address cannot be empty", nameof(newEmail));
            }

            try
            {
                var mailAddress = new MailAddress(newEmail);

                if (mailAddress.Address == newEmail)
                {
                    return true;
                }
            }

            catch
            {
                throw new ArgumentException("Email address format is invalid.", nameof(newEmail));
            }
            return false;
        }
    }
}
