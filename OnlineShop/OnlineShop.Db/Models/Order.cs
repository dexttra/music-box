using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class Order
	{
		public Guid Id { get; set; }

		public UserOrderInfo UserOrderInfo;
		public Cart Cart { get; set; }
		public OrderStatus OrderStatus { get; set; }
		public DateTime CreationTime { get; set; }
		public decimal Price { get; set; }

		public Order(UserOrderInfo userOrderInfo, Cart cart)
		{
			UserOrderInfo = userOrderInfo;
			Cart = cart;
			OrderStatus = OrderStatus.Created;
			CreationTime = DateTime.Now;
			Price = Cart.Price;
		}
	}
}
