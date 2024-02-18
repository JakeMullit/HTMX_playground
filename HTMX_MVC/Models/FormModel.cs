namespace HTMX_MVC.Models
{
    public class FormModel
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public bool HasAgreedToTerms { get; set; } = false;
    }
}
