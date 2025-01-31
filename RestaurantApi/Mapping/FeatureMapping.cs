using AutoMapper;
using Restaurant.DtoLayer.FeatureDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature,CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,GetFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
        }
    }
}
