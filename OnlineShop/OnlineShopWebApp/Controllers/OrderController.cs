using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class OrderController : Controller
	{
		private readonly ICartsStorage cartsStorage;
		private readonly IOrdersStorage ordersStorage;

		public OrderController(ICartsStorage cartsStorage, IOrdersStorage ordersStorage)
		{
			this.ordersStorage = ordersStorage;
			this.cartsStorage = cartsStorage;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Buy(UserOrderInfo userInfo)
		{
			if (ModelState.IsValid)
			{
				Cart cart = cartsStorage.TryGetByUserId(Constants.UserId);
				Order order = new Order(userInfo, cart);
				
				ordersStorage.Add(order);
				cartsStorage.ClearAll(Constants.UserId);
				return View();
			}
			return View("Index");
		}
	}
}
