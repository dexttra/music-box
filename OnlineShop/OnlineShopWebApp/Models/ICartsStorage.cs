namespace OnlineShopWebApp.Models
{
	public interface ICartsStorage
	{
		void Add(int userId, Product product);
		Cart TryGetByUserId(int userId);
		void RemoveItem(int userId, int productId);
		void ClearAll(int userId);
	}
}