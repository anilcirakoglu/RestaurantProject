using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;
using Restaurant.DtoLayer.AboutDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList() 
        {
            var values =_aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto) 
        {
            var value = _mapper.Map<About>(createAboutDto);
            _aboutService.TAdd(value);
            return Ok("Hakkımda Kısmı Başarılı Şekilde Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value =_aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda alanı silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto) 
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
             return Ok("Hakkımda alanı güncellendi");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id) 
        {
            var value=_aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
