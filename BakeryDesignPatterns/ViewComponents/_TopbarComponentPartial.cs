using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.ViewComponents
{
    public class _TopbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
