using AutoMapper;
using Restaurant.DtoLayer.DiscountDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount,ResultDiscountDto>().ReverseMap();
            CreateMap<Discount,CreateDiscountDto>().ReverseMap();
            CreateMap<Discount,GetDiscountDto>().ReverseMap();
            CreateMap<Discount,UpdateDiscountDto>().ReverseMap();
        }
    }
}
