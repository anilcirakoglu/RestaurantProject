using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccessLayer.Abstract;
using Restaurant.DataAccessLayer.Concrete;
using Restaurant.DataAccessLayer.Repositories;
using Restaurant.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(RestaurantContext context) : base(context)
        {
        }

        public List<Product> GetProductWithCategories()
        {
            var context = new RestaurantContext();
            //var values = (from p in context.Products
            //              join c in context.Categories
            //              on p.CategoryID equals c.CategoryID
            //              select new ResultProductWithCategory
            //              {
            //                  ProductID=p.ProductID,
            //                  ProductName = p.ProductName,
            //                  Description = p.Description,
            //                  ImageUrl = p.ImageUrl,
            //                  Price = p.Price,
            //                  ProductStatus = p.ProductStatus,
            //                  CategoryName = c.CategoryName
            //              }).ToList();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context = new RestaurantContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburgerr").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNamePriceByMaximum()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault(); 

        }

        public string ProductNamePriceByMinimum()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new RestaurantContext();
            return context.Products.Average(x=>x.Price);
        }

        public decimal ProductAvgPriceByHamburger()
        {
            using var context = new RestaurantContext();
            return context.Products.Where(x => x.CategoryID ==(context.Categories.Where(y=>y.CategoryName=="Hamburgerr").Select(z=>z.CategoryID).FirstOrDefault())).Average(w=>w.Price);
        }
    }
}
