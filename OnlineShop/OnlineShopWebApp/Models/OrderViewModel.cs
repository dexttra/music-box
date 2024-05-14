using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class OrderViewModel
	{
		public Guid Id { get; set; }
		public UserOrderInfoViewModel UserOrderInfo { get; set; }
		public List<CartItemViewModel> Items { get; set; }
		public OrderStatusViewModel Status { get; set; }
		public DateTime CreationTime { get; set; }
		public decimal Price { get; set; }

	}
}
