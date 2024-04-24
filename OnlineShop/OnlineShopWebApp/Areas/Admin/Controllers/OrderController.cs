using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class OrderController : Controller
	{
		private readonly IOrdersStorage ordersStorage;

		public OrderController(IOrdersStorage ordersStorage)
		{
			this.ordersStorage = ordersStorage;
		}

		public IActionResult Index()
		{
			var orders = ordersStorage.GetAll();
			return View(orders);
		}

		public ActionResult OrderDetails(int orderId)
		{
			var order = ordersStorage.TryGetById(orderId);
			return View(order);
		}

		[HttpPost]
		public ActionResult UpdateStatus(int orderId, OrderStatus newStatus)
		{
			ordersStorage.UpdateStatus(orderId, newStatus);
			return RedirectToAction("Orders");

		}

	}
}
