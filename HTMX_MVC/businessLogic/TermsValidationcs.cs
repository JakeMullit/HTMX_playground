namespace HTMX_MVC.businessLogic
{
    public static class TermsValidationcs
    {
        public static string ValidateTerms(bool hasAgreedToTerms)
        {
            if (!hasAgreedToTerms)
            {
                return "You must agree to the terms";
            }

            return string.Empty;
        }
    }
}
