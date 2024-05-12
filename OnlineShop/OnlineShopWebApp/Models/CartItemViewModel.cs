namespace OnlineShopWebApp.Models
{
	public class CartItemViewModel
	{
		public Guid Id { get; set; }
		public Guid CartId { get; set; }
		public ProductViewModel Product { get; set; }
		public int Amount { get; set; }

		public decimal Price
		{
			get
			{
				return Product.Price * Amount;
			}
			set { }
		}
	}
}
