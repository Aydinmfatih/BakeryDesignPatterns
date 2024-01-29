using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.Areas.AdminArea.Controllers
{
    public class AdminLayout : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
