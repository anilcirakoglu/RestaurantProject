using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
