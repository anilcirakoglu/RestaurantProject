﻿
using Restaurant.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> GetProductWithCategories();
        public int ProductCount();
        public int ProductCountByCategoryNameHamburger();
        public int ProductCountByCategoryNameDrink();
        public decimal ProductPriceAvg();
        string ProductNamePriceByMaximum();
        string ProductNamePriceByMinimum();
        decimal ProductAvgPriceByHamburger();
    }
}
