using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Cart
    {
		public Guid Id { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

		public Cart()
		{
			Items = new List<CartItem>();
		}

	}
}
