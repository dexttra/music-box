using OnlineShop.Db.Models;

namespace OnlineShopWebApp.Models
{
	public class CartItem
	{
		public Guid Id { get; set; }
		public Product Product { get; set; }
		public int Amount { get; set; }
		public decimal Price {  get; set; }
	}
}
