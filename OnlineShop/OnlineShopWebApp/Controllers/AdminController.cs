using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class AdminController : Controller
	{
		private readonly IProductsStorage productsStorage;
		private readonly IOrdersStorage ordersStorage;
		private readonly IRolesStorage rolesStorage;

		public AdminController(IProductsStorage productsStorage, IOrdersStorage ordersStorage, IRolesStorage rolesStorage)
		{
			this.productsStorage = productsStorage;
			this.ordersStorage = ordersStorage;
			this.rolesStorage = rolesStorage;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Orders()
		{
			var orders = ordersStorage.GetAll();
			return View(orders);
		}


		public IActionResult Users()
		{
			return View();
		}
		public IActionResult Roles()
		{
			var roles = rolesStorage.GetAll();
			return View(roles);
		}

		public IActionResult AddRole()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult AddRole(Role role)
		{
			if (rolesStorage.TryGetByName(role.Name) is not null)
			{
				ModelState.AddModelError("Name", "Такая роль уже существует");
			}	
			if (ModelState.IsValid)
			{
				rolesStorage.AddRole(role);
				return RedirectToAction("Roles");
			}
			return View(role);
		}
		public IActionResult RemoveRole(string roleName)
		{
			rolesStorage.RemoveRole(roleName);
			return RedirectToAction("Roles");
		}
		public IActionResult Products()
		{
			var products = productsStorage.GetAll();
			return View(products);
		}

		public IActionResult AddProduct()
		{
			return View();
		}


		[HttpPost]
		public IActionResult AddProduct(Product product)
		{
			if (ModelState.IsValid)
			{
				productsStorage.AddProduct(product);
				return RedirectToAction("Products");
			}
			return View("AddProduct");

		}
		public IActionResult EditProduct(int productId)
		{
			var product = productsStorage.TryGetById(productId);
			return View(product);
		}


		[HttpPost]
		public IActionResult EditProduct(Product product)
		{
			if (ModelState.IsValid)
			{
				productsStorage.EditProduct(product);
				return RedirectToAction("Products");
			}
			return RedirectToAction("EditProduct");
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
