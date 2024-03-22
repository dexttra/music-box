namespace OnlineShopWebApp.Models
{
	public interface ICartsStorage
	{
		void Add(Product product, int userId);
		Cart TryGetByUserId(int userId);
	}
}