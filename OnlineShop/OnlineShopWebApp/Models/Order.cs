using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class Order
	{
		private static int uniqId = 1;
		public int Id { get;  }

		public UserOrderInfo UserOrderInfo;
		public CartViewModel Cart { get; set; }
		public OrderStatus OrderStatus { get; set; }
		public DateTime CreationTime { get; set; }
		public decimal Price { get; set; }


		public Order(UserOrderInfo userOrderInfo, CartViewModel cart)
		{
			Id = uniqId++;
			UserOrderInfo = userOrderInfo;
			Cart = cart;
			OrderStatus = OrderStatus.Created;
			CreationTime = DateTime.Now;
			Price = Cart.Price;
		}
		public Order()
		{		
		}
	}
}
