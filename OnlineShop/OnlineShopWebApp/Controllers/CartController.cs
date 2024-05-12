using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Controllers
{
	public class CartController : Controller
	{
		private readonly ICartsRepository cartsRepository;
		private readonly IProductsRepository productsRepository;

		public CartController(ICartsRepository cartsStorage, IProductsRepository productsStorage)
		{
			this.cartsRepository = cartsStorage;
			this.productsRepository = productsStorage;
		}

		public IActionResult Index()
		{
			var cart = cartsRepository.TryGetByUserId(Constants.UserId);
			if (cart is null || cart.Items is null) return View();

			var cartItemsViewModel = new List<CartItemViewModel>();
			foreach (CartItem cartItem in cart.Items)
			{
				var cartItemViewModel = new CartItemViewModel
				{
					Id = cartItem.Id,
					Product = new ProductViewModel
					{
						Id = cartItem.Product.Id,
						Name = cartItem.Product.Name,
						Description = cartItem.Product.Description,
						Price = cartItem.Product.Price,
						ImagePath = cartItem.Product.ImagePath
					},
					Amount = cartItem.Amount,
					Price = cartItem.Price
				};
				cartItemsViewModel.Add(cartItemViewModel);
			}
			var cartViewModel = new CartViewModel
			{
				UserId = cart.UserId,
				Items = cartItemsViewModel,
				Price = cart.Price,
				Amount = cart.Amount
			};
			return View(cartViewModel);
		}

		public IActionResult Add(Guid productId)
		{
			var product = productsRepository.TryGetById(productId);
			cartsRepository.Add(Constants.UserId, product);
			return RedirectToAction("Index");
		}
		public IActionResult RemoveItem(int userId, Guid productId)
		{
			cartsRepository.RemoveItem(Constants.UserId, productId);
			return RedirectToAction("Index");
		}
		public IActionResult ClearAll(Guid userId)
		{
			cartsRepository.ClearAll(Constants.UserId);
			return RedirectToAction("Index");
		}
	}
}
