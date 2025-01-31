using AutoMapper;
using Restaurant.DtoLayer.SocialMediaDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap(); 
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap(); 
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap(); 
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap(); 
        }
    }
}
