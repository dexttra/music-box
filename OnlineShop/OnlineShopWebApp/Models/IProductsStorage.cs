namespace OnlineShopWebApp.Models
{
	public interface IProductsStorage
	{
		Product TryGetById(int id);
		List<Product> GetAll();
		void AddProduct(Product product);
		void EditProduct(Product product);
	}
}