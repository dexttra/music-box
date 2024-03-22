namespace OnlineShopWebApp.Models
{
	public interface IProductsStorage
	{
		Product TryGetById(int id);
		List<Product> GetAll();
	}
}