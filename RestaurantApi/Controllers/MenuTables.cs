using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTables : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTables(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }
        [HttpGet("MenuTableCount")]
        public ActionResult MenuTableCount() 
        {
            return Ok(_menuTableService.TMenuTableCount());
        }
    }
}
