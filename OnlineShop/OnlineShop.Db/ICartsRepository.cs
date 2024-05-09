using OnlineShop.Db.Models;

namespace OnlineShopWebApp.Models
{
	public interface ICartsRepository
	{
		void Add(Guid userId, Product product);
		Cart TryGetByUserId(Guid userId);
		void RemoveItem(Guid userId, Guid productId);
		void ClearAll(Guid userId);
	}
}