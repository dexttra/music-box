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
		public IActionResult Buy(Order order)
		{
			order.Cart = cartsStorage.TryGetByUserId(Constants.UserId);
			ordersStorage.Add(order);
			cartsStorage.ClearAll(Constants.UserId);
			return View(order);
		}
	}
}
 