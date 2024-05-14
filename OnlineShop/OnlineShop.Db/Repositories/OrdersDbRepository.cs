using Microsoft.EntityFrameworkCore;
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
			databaseContext.SaveChanges();
		}

		public List<Order> GetAll()
		{
			return databaseContext.Orders.Include(x => x.UserOrderInfo)
				.Include(x => x.Items).ThenInclude(x => x.Product).ToList();
		}

		public Order TryGetById(Guid id)
		{
			return databaseContext.Orders.Include(x => x.UserOrderInfo)
				.Include(x => x.Items)
				.ThenInclude(x => x.Product)
				.FirstOrDefault(x => x.Id == id);
		}

		public void UpdateStatus(Guid orderId, OrderStatus newStatus)
		{
			var order = TryGetById(orderId);
			if (order != null)
			{
				order.Status = newStatus;
			}
			databaseContext.SaveChanges();
		}
	}
}
