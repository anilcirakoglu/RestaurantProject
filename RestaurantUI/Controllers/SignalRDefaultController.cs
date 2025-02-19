using Microsoft.AspNetCore.Mvc;

namespace RestaurantUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
