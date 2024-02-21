using Microsoft.AspNetCore.Mvc;

namespace HTMX_MVC.Controllers
{
    public class SlowPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
