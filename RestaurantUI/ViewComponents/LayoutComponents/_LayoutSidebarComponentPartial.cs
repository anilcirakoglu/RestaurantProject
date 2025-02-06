using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
