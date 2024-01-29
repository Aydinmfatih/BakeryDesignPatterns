using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
