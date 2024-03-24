using Microsoft.AspNetCore.Http.Features;
using System.Reflection.Metadata.Ecma335;

namespace OnlineShopWebApp.Models
{
    public class OrdersInMemoryStorage : IOrdersStorage
    {
        private readonly List<Cart> orders = new List<Cart>();


        public void Add(Cart cart)
        {
           orders.Add(cart);
        }
    }
}
