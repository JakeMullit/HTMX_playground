namespace HTMX_MVC.businessLogic
{
    public static class NameValidation
    {
        public static string ValidateName(string name)
        {
            name = name.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(name))
            {
                return "Name is required";
            }

            if (name.Split(" ").Contains("jacob"))
            {
                return "Change name, there can only be one Jacob";
            }

            if (name.Length < 3)
            {
                return "Name must be at least 3 characters long";
            }

            if (name.Length > 50)
            {
                return "Name must be less than 50 characters long";
            }

            if (name.Split(" ").Length <= 1)
            {
                return "Name must contain at least 2 words";
            }



            return string.Empty;
        }
    }
}
