using AutoMapper;
using Restaurant.DtoLayer.CategoryDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
                CreateMap<Category,ResultCategoryDto>().ReverseMap();
                CreateMap<Category, CreateCategoryDto>().ReverseMap();
                CreateMap<Category, GetCategoryDto>().ReverseMap();
                CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
