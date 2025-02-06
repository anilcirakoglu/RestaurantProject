using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponentPartial: ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
