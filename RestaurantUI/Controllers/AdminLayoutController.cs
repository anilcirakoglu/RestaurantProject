using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
