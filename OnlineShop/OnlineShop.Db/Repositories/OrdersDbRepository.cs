using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;

namespace OnlineShop.Db.Repositories
{
	public class OrdersDbRepository : IOrdersRepository
	{
		private readonly DatabaseContext databaseContext;

		public OrdersDbRepository(DatabaseContext databaseContext)
		{
			this.databaseContext = databaseContext;
		}


		public void Add(Order order)
		{
			databaseContext.Orders.Add(order);
		}

		public List<Order> GetAll()
		{
			return databaseContext.Orders.ToList();
		}

		public Order TryGetById(Guid orderId)
		{
			return databaseContext.Orders.FirstOrDefault(order => order.Id == orderId);
		}

		public void UpdateStatus(Guid orderId, OrderStatus newStatus)
		{
			var order = TryGetById(orderId);
			if (order != null)
			{
				order.OrderStatus = newStatus;
			}
		}
	}
}
