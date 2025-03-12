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
    public class EfMenuTableDal : GenericRepository<MenuTable>, IMenuTableDal
    {
        public EfMenuTableDal(RestaurantContext context) : base(context)
        {
        }

        public int MenuTableCount()
        {
            using var context = new RestaurantContext();
            return context.MenuTables.Count();
        }
    }
}
