using HTMX_MVC.businessLogic;
using HTMX_MVC.Controllers.ControllerUtils;
using HTMX_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTMX_MVC.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            var model = HttpContext.GetCreateModel<FormModel>();
            return View(model);
        }

        [HttpPost]
        public IActionResult ContactForm()
        {
            var model = HttpContext.GetCreateModel<FormModel>();

            model.NameError = NameValidation.ValidateName(model.Name);
            model.EmailError = EmailValidation.ValidateEmail(model.Email);
            model.PasswordError = PasswordValidation.ValidatePassword(model.Password);
            model.HasAgreedToTermsError = TermsValidationcs.ValidateTerms(model.HasAgreedToTerms);

            if (
                string.IsNullOrEmpty(model.NameError)
                &&
                string.IsNullOrEmpty(model.EmailError)
                &&
                string.IsNullOrEmpty(model.PasswordError)
                &&
                string.IsNullOrEmpty(model.HasAgreedToTermsError)
            )
            {
                Response.Headers.Add("HX-Redirect", "SlowPage");
                Thread.Sleep(5000);
            };

            HttpContext.SaveModel(model);
            return PartialView(model);
        }

        [HttpPut]
        public IActionResult InputName(string name)
        {
            var model = HttpContext.GetCreateModel<FormModel>();
            model.Name = name ?? string.Empty;
            model.NameError = NameValidation.ValidateName(model.Name);

            HttpContext.SaveModel(model);
            return PartialView(model);
        }

        [HttpPut]
        public IActionResult InputEmail(string email)
        {
            var model = HttpContext.GetCreateModel<FormModel>();
            model.Email = email ?? string.Empty;
            model.EmailError = EmailValidation.ValidateEmail(model.Email);
            HttpContext.SaveModel(model);

            return PartialView(model);
        }

        [HttpPut]
        public IActionResult InputPassword(string password)
        {
            var model = HttpContext.GetCreateModel<FormModel>();
            model.Password = password ?? string.Empty;
            model.PasswordError = PasswordValidation.ValidatePassword(model.Password);
            HttpContext.SaveModel(model);

            return PartialView(model);
        }

        [HttpPut]
        public IActionResult InputTerms(string acceptedTerms)
        {
            var model = HttpContext.GetCreateModel<FormModel>();

            model.HasAgreedToTerms = acceptedTerms == "on";
            model.HasAgreedToTermsError = TermsValidationcs.ValidateTerms(model.HasAgreedToTerms);
            HttpContext.SaveModel(model);

            return PartialView(model);
        }
    }
}
