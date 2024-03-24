using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Controllers
{
	public class CartController : Controller
	{
		private readonly ICartsStorage cartsStorage;
		private readonly IProductsStorage productsStorage;

		public CartController(ICartsStorage cartsStorage, IProductsStorage productsStorage)
		{
			this.cartsStorage = cartsStorage;
			this.productsStorage = productsStorage;
		}

		public IActionResult Index()
		{
			var cart = cartsStorage.TryGetByUserId(Constants.UserId);
			return View(cart);
		}

		public IActionResult Add(int productId)
		{
			var product = productsStorage.TryGetById(productId);
			cartsStorage.Add(Constants.UserId, product);
			return RedirectToAction("Index");
		}
		public IActionResult RemoveItem(int userId, int productId)
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
