
using Restaurant.DtoLayer.ProductDto;
using Restaurant.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<ResultProductWithCategory> TGetProductWithCategories();
        public int TProductCount();

        public int TProductCountByCategoryNameHamburger();
        public int TProductCountByCategoryNameDrink();
        public decimal TProductPriceAvg();
        string TProductNamePriceByMaximum();
        string TProductNamePriceByMinimum();
        decimal TProductAvgPriceByHamburger();
    }
}
