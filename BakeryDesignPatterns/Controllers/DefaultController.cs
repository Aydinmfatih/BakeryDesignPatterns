using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
