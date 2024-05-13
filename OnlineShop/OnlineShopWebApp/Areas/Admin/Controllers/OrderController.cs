using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShop.Db.Models;
using OnlineShop.Db.Repositories;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")] 
	public class OrderController : Controller
	{
		private readonly IOrdersRepository ordersStorage;

		public OrderController(IOrdersRepository ordersStorage)
		{
			this.ordersStorage = ordersStorage;
		}

		public IActionResult Index()
		{
			var orders = ordersStorage.GetAll();
			return View(orders);
		}

		public ActionResult Details(Guid orderId)
		{
			var order = ordersStorage.TryGetById(orderId);
			return View(order);
		}

		[HttpPost]
		public ActionResult UpdateStatus(Guid orderId, OrderStatusViewModel newStatus)
		{
			ordersStorage.UpdateStatus(orderId, newStatus);
			return RedirectToAction("Index");

		}

	}
}
