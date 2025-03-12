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
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>,IMoneyCaseDal
    {
        public EfMoneyCaseDal(RestaurantContext context) : base(context) { }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new RestaurantContext();
            return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
