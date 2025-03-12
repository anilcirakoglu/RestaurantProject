using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCases : ControllerBase
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCases(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }
        [HttpGet("TTotalMoneyCaseAmount")]
        public IActionResult TTotalMoneyCaseAmount() {
        
        return Ok(_moneyCaseService.TTotalMoneyCaseAmount());
        
        }
    }
}
