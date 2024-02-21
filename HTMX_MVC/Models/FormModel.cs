namespace HTMX_MVC.Models
{
    public class FormModel
    {
        public string Name { get; set; } = "";
        public string NameError { get; set; } = "";
        public string Email { get; set; } = "";
        public string EmailError { get; set; } = "";
        public string Password { get; set; } = "";
        public string PasswordError { get; set; } = "";
        public bool HasAgreedToTerms { get; set; } = false;
        public string HasAgreedToTermsError { get; set; } = "";

        public bool loading { get; set; } = false;
    }
}
