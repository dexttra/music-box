using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class OrderController : Controller
	{
		private readonly ICartsRepository cartsRepository;
		private readonly IOrdersStorage ordersStorage;

		public OrderController(ICartsRepository cartsStorage, IOrdersStorage ordersStorage)
		{
			this.ordersStorage = ordersStorage;
			this.cartsRepository = cartsStorage;
		}

		public IActionResult Index()
		{
			return View();
		}

		//[HttpPost]
		//public IActionResult Buy(UserOrderInfo userInfo)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		CartViewModel cart = cartsRepository.TryGetByUserId(Constants.UserId);
		//		Order order = new Order(userInfo, cart);
				
		//		ordersStorage.Add(order);
		//		cartsRepository.ClearAll(Constants.UserId);
		//		return View();
		//	}
		//	return View("Index");
		//}
	}
}
