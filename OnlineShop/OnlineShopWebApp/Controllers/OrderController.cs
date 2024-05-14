using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db.Repositories;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class OrderController : Controller
	{
		private readonly ICartsRepository cartsRepository;
		private readonly IOrdersRepository ordersRepository;

		public OrderController(ICartsRepository cartsStorage, IOrdersRepository ordersStorage)
		{
			this.ordersRepository = ordersStorage;
			this.cartsRepository = cartsStorage;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Buy(UserOrderInfoViewModel userInfo)
		{
			if (ModelState.IsValid)
			{
				Cart cart = cartsRepository.TryGetByUserId(Constants.UserId);
				var userOrderInfo = new UserOrderInfo
				{
					Name = userInfo.Name,
					Surname = userInfo.Surname,
					Email = userInfo.Email,
					Phone = userInfo.Phone,
					City = userInfo.City,
					Street = userInfo.Street
				};

				Order order = new Order
				{
					UserOrderInfo = userOrderInfo,
					Items = cart.Items,
					Price = cart.Price,
				}; 

				ordersRepository.Add(order);
				cartsRepository.ClearAll(Constants.UserId);
				return View();
			}
			return View("Index");
	
		}
	}
}
