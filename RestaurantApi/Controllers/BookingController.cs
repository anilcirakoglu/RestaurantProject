using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.BusinessLayer.Abstract;

using Restaurant.DtoLayer.BookingDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            var value = _mapper.Map<Booking>(createBookingDto);
            _bookingService.TAdd(value);
            return Ok("Reservasyon yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto) 
        {
            var value =_mapper.Map<Booking>(updateBookingDto);
            _bookingService.TUpdate(value);
            return Ok("Rezervasyon Güncellendi");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id) 
        {
            var value =_bookingService.TGetByID(id);
            return Ok(value);
        }

    }
}
