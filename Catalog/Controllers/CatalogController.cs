using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
