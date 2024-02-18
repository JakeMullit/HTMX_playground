using Microsoft.AspNetCore.Mvc;

namespace HTMX_MVC.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
