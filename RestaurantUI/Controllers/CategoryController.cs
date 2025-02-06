using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
