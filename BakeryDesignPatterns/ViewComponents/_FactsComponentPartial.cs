using Microsoft.AspNetCore.Mvc;

namespace BakeryDesignPatterns.ViewComponents
{
    public class _FactsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
