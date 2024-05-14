using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class Order
	{
		public Guid Id { get; set; }
		public UserOrderInfo UserOrderInfo { get; set; }
		public List<CartItem> Items { get; set; }
		public OrderStatus Status { get; set; }
		public DateTime CreationTime { get; set; }
		public decimal Price { get; set; }

		public Order()
		{
			Items = new List<CartItem>();
			Status = OrderStatus.Created;
			CreationTime = DateTime.Now;
		}

	}
}
