using System.Text.RegularExpressions;

namespace HTMX_MVC.businessLogic
{
    public static class EmailValidation
    {
        public static string ValidateEmail(string email)
        {
            email = email.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(email))
            {
                return "Email is required";
            }


            if (email.Length > 50)
            {
                return "Email must be less than 50 characters long";
            }

            if (!email.Contains("@"))
            {
                return "Email must contain an @ symbol";
            }

            if (!email.Contains("."))
            {
                return "Email must contain a . symbol";
            }

            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(email, pattern))
            {
                return "Email is not valid";
            }
            return string.Empty;

        }
    }
}
