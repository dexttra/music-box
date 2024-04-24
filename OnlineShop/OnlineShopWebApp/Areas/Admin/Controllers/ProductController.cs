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

		public IActionResult Index()
		{
			var products = productsStorage.GetAll();
			return View(products);
		}

		public IActionResult Add()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Add(Product product)
		{
			if (ModelState.IsValid)
			{
				productsStorage.AddProduct(product);
				return RedirectToAction("Index");
			}
			return View("Add");

		}
		public IActionResult Edit(int productId)
		{
			var product = productsStorage.TryGetById(productId);
			return View(product);
		}


		[HttpPost]
		public IActionResult Edit(Product product)
		{
			if (ModelState.IsValid)
			{
				productsStorage.EditProduct(product);
				return RedirectToAction("Index");
			}
			return RedirectToAction("Edit");
		}


	}
}
