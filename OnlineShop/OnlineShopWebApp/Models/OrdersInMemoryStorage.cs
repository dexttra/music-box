using Microsoft.AspNetCore.Http.Features;
using System.Reflection.Metadata.Ecma335;

namespace OnlineShopWebApp.Models
{
    public class OrdersInMemoryStorage : IOrdersStorage
    {
        private readonly List<Order> orders = new List<Order>();


        public void Add(Order order)
        {
           orders.Add(order);
        }
    }
}
