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

		public List<Order> GetAll()
		{
			return orders;
		}

		public Order TryGetById(int orderId)
		{
			return orders.FirstOrDefault(order => order.Id == orderId);
		}

		public void UpdateStatus(int orderId, OrderStatus newStatus)
		{
			var order = TryGetById(orderId);
			if (order != null)
			{
				order.OrderStatus = newStatus;
			}
		}
	}
}
