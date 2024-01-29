using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

