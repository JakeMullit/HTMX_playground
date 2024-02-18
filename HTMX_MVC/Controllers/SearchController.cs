using HTMX_MVC.Controllers.ControllerUtils;
using HTMX_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HTMX_MVC.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = HttpContext.GetCreateModel<SearchModel>();
            return View(model);
        }

        [HttpGet]
        public IActionResult Search(string searchQuery)
        {
            var model = HttpContext.GetCreateModel<SearchModel>();
            model.SearchQuery = searchQuery ?? string.Empty; ;

            HttpContext.SaveModel(model);
            return PartialView(model);
        }
    }
}
