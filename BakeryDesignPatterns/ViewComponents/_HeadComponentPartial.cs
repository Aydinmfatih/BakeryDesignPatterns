using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
