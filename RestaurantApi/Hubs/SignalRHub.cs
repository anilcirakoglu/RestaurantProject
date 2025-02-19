using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Restaurant.DataAccessLayer.Concrete;

namespace RestaurantApi.Hubs
{
    public class SignalRHub:Hub
    {
        RestaurantContext context= new RestaurantContext();
        public async Task SendCategoryCount() {
            var value=context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        } 
    }
}
