using AutoMapper;
using Restaurant.DtoLayer.ProductDto;
using Restaurant.EntityLayer.Entities;

namespace RestaurantApi.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,GetProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductWithCategory>().ReverseMap();
        }
    }
}
