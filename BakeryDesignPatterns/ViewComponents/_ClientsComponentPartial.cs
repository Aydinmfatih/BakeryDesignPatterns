using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.ViewComponents
{
    public class _ClientsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
