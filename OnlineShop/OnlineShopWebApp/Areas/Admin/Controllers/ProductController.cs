using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ProductController : Controller
	{
		private readonly IProductsStorage productsStorage;

		public ProductController(IProductsStorage productsStorage)
		{
			this.productsStorage = productsStorage;
		}

		public IActionResult Users()
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
