using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis;
using OnlineShop.Db;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Controllers
{
	public class CartController : Controller
	{
		private readonly ICartsRepository cartsStorage;
		private readonly IProductsRepository productsStorage;

		public CartController(ICartsRepository cartsStorage, IProductsRepository productsStorage)
		{
			this.cartsStorage = cartsStorage;
			this.productsStorage = productsStorage;
		}

		public IActionResult Index()
		{
			var cart = productsStorage.GetAll();
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
			var cart = cartsStorage.TryGetByUserId(Constants.UserId);
			return View(cart);
		}

		public IActionResult Add(Guid productId)
		{
			var product = productsStorage.TryGetById(productId);
			cartsStorage.Add(Constants.UserId, product);
			return RedirectToAction("Index");
		}
		public IActionResult RemoveItem(int userId, Guid productId)
		{
			cartsStorage.RemoveItem(Constants.UserId, productId);
			return RedirectToAction("Index");
		}
		public IActionResult ClearAll(int userId)
		{
			cartsStorage.ClearAll(Constants.UserId);
			return RedirectToAction("Index");
		}
	}
}
