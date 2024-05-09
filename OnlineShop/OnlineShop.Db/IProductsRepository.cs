using OnlineShop.Db.Models;

namespace OnlineShop.Db
{
	public interface IProductsRepository
	{
		Product TryGetById(Guid id);
		List<Product> GetAll();
		void AddProduct(Product product);
		void EditProduct(Product product);
	}
}