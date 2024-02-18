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

        [HttpPut]
        public IActionResult InputName(string name)
        {
            var model = HttpContext.GetCreateModel<FormModel>();
            model.Name = name;
            HttpContext.SaveModel(model);

            return PartialView(model);
        }

        [HttpPut]
        public IActionResult InputEmail(string email)
        {
            var model = HttpContext.GetCreateModel<FormModel>();
            model.Email = email;
            HttpContext.SaveModel(model);

            return PartialView(model);
        }

        [HttpPut]
        public IActionResult InputPassword(string password)
        {
            var model = HttpContext.GetCreateModel<FormModel>();
            model.Password = password;
            HttpContext.SaveModel(model);

            return PartialView(model);
        }
    }
}
