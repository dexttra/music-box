using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
	public class OrderController : Controller
	{
		private readonly ICartsRepository cartsRepository;
		private readonly IOrdersStorage ordersStorage;

		public OrderController(ICartsRepository cartsStorage, IOrdersStorage ordersStorage)
		{
			this.ordersStorage = ordersStorage;
			this.cartsRepository = cartsStorage;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Buy(UserOrderInfo userInfo)
		{
			if (ModelState.IsValid)
			{
				var cart = cartsRepository.TryGetByUserId(Constants.UserId);				
				var cartItemsViewModel = new List<CartItemViewModel>();

				foreach (CartItem cartItem in cart.Items)
				{
					var cartItemViewModel = new CartItemViewModel
					{
						Id = cartItem.Id,
						CartId = cartItem.CartId,
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
				Order order = new Order(userInfo, cartViewModel);
				ordersStorage.Add(order);
				cartsRepository.ClearAll(Constants.UserId);
				return View();
			}
			return View("Index");
		}
	}
}
