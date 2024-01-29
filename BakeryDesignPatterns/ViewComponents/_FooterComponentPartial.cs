using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
