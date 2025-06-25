using System.Net.Mail;

namespace Sahara.API.Helpers
{
    public static class EmailValidator
    {
        public static bool IsValidEmailFormat(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }


            try
            {
                var mailAddress = new MailAddress(email);

                if (mailAddress.Address == email)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
