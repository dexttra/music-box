using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class AdminController : Controller
	{
		private readonly IProductsStorage productsStorage;

		public AdminController(IProductsStorage productsStorage)
		{
			this.productsStorage = productsStorage;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Orders()
		{
			return View();
		}
		public IActionResult Users()
		{
			return View();
		}
		public IActionResult Roles()
		{
			return View();
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

	}
}
