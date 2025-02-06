using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
