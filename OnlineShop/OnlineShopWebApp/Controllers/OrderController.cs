using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class OrderController : Controller
	{
		private readonly ICartsStorage cartsStorage;
		private readonly IOrdersStorage ordersStorage;

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Buy()
		{
			return View();
		}
	}
}
