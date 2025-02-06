using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() {

            return View();
        }
    }
}
