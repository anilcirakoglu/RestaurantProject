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
           var values= context.Products.Include(x => x.Category).ToList();
            return values;
        }

        
    }
}
