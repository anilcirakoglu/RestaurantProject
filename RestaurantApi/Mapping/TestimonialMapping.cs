using AutoMapper;
using Restaurant.DtoLayer.TestimonialDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
               CreateMap<Testimonial,ResultTestimonialDto>().ReverseMap();
               CreateMap<Testimonial,CreateTestimonialDto>().ReverseMap();
               CreateMap<Testimonial,GetTestimonialDto>().ReverseMap();
               CreateMap<Testimonial,UpdateTestimonialDto>().ReverseMap();
        }
    }
}
