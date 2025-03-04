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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(RestaurantContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
           using var context = new RestaurantContext();
            return context.Categories.Where(x=>x.Status==true).Count();
        }

        public int CategoryCount()
        {
            using var context = new RestaurantContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new RestaurantContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
