using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;

namespace OnlineShop.Db.Repositories
{
	public interface IOrdersRepository
    {
        void Add(Order order);
        
        List<Order> GetAll();
		Order TryGetById(Guid orderId);
		void UpdateStatus(Guid orderId, OrderStatus newStatus);
	}
}