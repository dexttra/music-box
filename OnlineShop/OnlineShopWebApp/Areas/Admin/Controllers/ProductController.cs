using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ProductController : Controller
	{
		private readonly IProductsRepository productsStorage;

		public ProductController(IProductsRepository productsStorage)
		{
			this.productsStorage = productsStorage;
		}

		public IActionResult Index()
		{
			var products = productsStorage.GetAll();
			var productsViewModel = new List<ProductViewModel>();
			foreach (var product in products)
			{
				var productViewModel = new ProductViewModel
				{
					Id = product.Id,
					Name = product.Name,
					Description = product.Description,
					Price = product.Price,
					ImagePath = product.ImagePath
				};
				productsViewModel.Add(productViewModel);
			}
			return View(productsViewModel);
		}

		public IActionResult Add()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Add(ProductViewModel product)
		{
			if (ModelState.IsValid)
			{
				var productDb = new Product
				{
					Name = product.Name,
					Price = product.Price,
					Description = product.Description,
					ImagePath = product.ImagePath
				};
				productsStorage.AddProduct(productDb);
				return RedirectToAction("Index");
			}
			return View("Add");

		}
		public IActionResult Edit(Guid productId)
		{
			var product = productsStorage.TryGetById(productId);
			return View(product);
		}


		[HttpPost]
		public IActionResult Edit(ProductViewModel product)
		{
			if (ModelState.IsValid)
			{
				var productDb = new Product
				{
					Name = product.Name,
					Price = product.Price,
					Description = product.Description
				};
				productsStorage.EditProduct(productDb);
				return RedirectToAction("Index");
			}
			return RedirectToAction("Edit");
		}


	}
}
