using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class OrderViewModel
	{
		private static int uniqId = 1;
		public int Id { get;  }

		public UserOrderInfoViewModel UserOrderInfo;
		public CartViewModel Cart { get; set; }
		public OrderStatusViewModel OrderStatus { get; set; }
		public DateTime CreationTime { get; set; }
		public decimal Price { get; set; }


		public OrderViewModel(UserOrderInfoViewModel userOrderInfo, CartViewModel cart)
		{
			Id = uniqId++;
			UserOrderInfo = userOrderInfo;
			Cart = cart;
			OrderStatus = OrderStatusViewModel.Created;
			CreationTime = DateTime.Now;
			Price = Cart.Price;
		}
		public OrderViewModel()
		{		
		}
	}
}
