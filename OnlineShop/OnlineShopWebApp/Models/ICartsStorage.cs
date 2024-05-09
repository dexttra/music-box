namespace OnlineShopWebApp.Models
{
	public interface ICartsStorage
	{
		//void Add(Guid userId, ProductViewModel product);
		Cart TryGetByUserId(Guid userId);
		void RemoveItem(Guid userId, Guid productId);
		void ClearAll(Guid userId);
	}
}