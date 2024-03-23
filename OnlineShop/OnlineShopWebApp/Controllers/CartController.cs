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
			cartsStorage.Add(product, Constants.UserId);
			return RedirectToAction("Index");
		}
		public IActionResult Remove(int productId)
		{
			var product = productsStorage.TryGetById(productId);
			cartsStorage.Remove(product, Constants.UserId);
			return RedirectToAction("Index");
		}
		public IActionResult ClearAll()
		{
			var cart = cartsStorage.TryGetByUserId(Constants.UserId);
			cartsStorage.ClearAll(cart);
			return RedirectToAction("Index");
		}
	}
}
