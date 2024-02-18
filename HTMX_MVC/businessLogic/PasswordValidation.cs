namespace HTMX_MVC.businessLogic
{
    public static class PasswordValidation
    {
        public static string ValidatePassword(string password)
        {
            password = password.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                return "Password is required";
            }

            if (password.Length < 8)
            {
                return "Password must be at least 8 characters long";
            }

            if (password.Length > 50)
            {
                return "Password must be less than 50 characters long";
            }

            return string.Empty;
        }
    }
}
