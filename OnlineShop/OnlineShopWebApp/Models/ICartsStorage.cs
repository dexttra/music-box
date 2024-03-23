namespace OnlineShopWebApp.Models
{
	public interface ICartsStorage
	{
		void Add(Product product, int userId);
		Cart TryGetByUserId(int userId);
		void Remove(Product product, int userId);
		void ClearAll(Cart cart);
	}
}