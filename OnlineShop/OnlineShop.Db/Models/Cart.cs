using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Cart
    {
		public Guid Id { get; set; }
        public List<CartItem> Items { get; set; }
		public decimal Price
		{
			get
			{
				return Items.Sum(x => x.Price);
			}
			set { }
		}

		public int Amount
		{
			get
			{
				return Items?.Sum(x => x.Amount) ?? 0;
			}
			set { }
		}

		public Cart()
		{
			Items = new List<CartItem>();
		}

	}
}
