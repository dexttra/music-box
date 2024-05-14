using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShop.Db.Models;
using OnlineShop.Db.Repositories;
using System.Net;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class OrderController : Controller
	{
		private readonly IOrdersRepository ordersStorage;

		public OrderController(IOrdersRepository ordersStorage)
		{
			this.ordersStorage = ordersStorage;
		}

		public IActionResult Index()
		{
			var orders = ordersStorage.GetAll();
			var ordersViewModel = new List<OrderViewModel>();

			foreach (var order in orders)
			{
				// Items mapping
				var ItemsViewModel = new List<CartItemViewModel>();
				foreach (CartItem item in order.Items)
				{
					var ItemViewModel = new CartItemViewModel
					{
						Id = item.Id,
						Product = new ProductViewModel
						{
							Id = item.Product.Id,
							Name = item.Product.Name,
							Description = item.Product.Description,
							Price = item.Product.Price,
							ImagePath = item.Product.ImagePath
						},
						Amount = item.Amount,
						Price = item.Price
					};

					ItemsViewModel.Add(ItemViewModel);
				}

				// OrderStatus mapping
				int statusIndex = (int)order.Status;
				var newOrderStatus = new OrderStatusViewModel();

				switch (statusIndex)
				{
					case 0: newOrderStatus = OrderStatusViewModel.Created; break;
					case 1: newOrderStatus = OrderStatusViewModel.Processed; break;
					case 2: newOrderStatus = OrderStatusViewModel.Delivering; break;
					case 3: newOrderStatus = OrderStatusViewModel.Delivered; break;
					case 4: newOrderStatus = OrderStatusViewModel.Received; break;
					case 5: newOrderStatus = OrderStatusViewModel.Canceled; break;
				}

				var orderViewModel = new OrderViewModel
				{
					Id = order.Id,
					UserOrderInfo = new UserOrderInfoViewModel
					{
						Name = order.UserOrderInfo.Name,
						Surname = order.UserOrderInfo.Surname,
						Email = order.UserOrderInfo.Email,
						Phone = order.UserOrderInfo.Phone,
						City = order.UserOrderInfo.City,
						Street = order.UserOrderInfo.Street
					},
					Items = ItemsViewModel,
					Status = newOrderStatus,
					CreationTime = order.CreationTime,
					Price = order.Price
				};
				ordersViewModel.Add(orderViewModel);
			}
			return View(ordersViewModel);
		}




		public ActionResult Details(Guid id)
		{
			var order = ordersStorage.TryGetById(id);

			// Items mapping
			var itemsViewModel = new List<CartItemViewModel>();
			foreach (CartItem item in order.Items)
			{
				var itemViewModel = new CartItemViewModel
				{
					Id = item.Id,
					Product = new ProductViewModel
					{
						Id = item.Product.Id,
						Name = item.Product.Name,
						Description = item.Product.Description,
						Price = item.Product.Price,
						ImagePath = item.Product.ImagePath
					},
					Amount = item.Amount,
					Price = item.Price
				};
				itemsViewModel.Add(itemViewModel);
			}

			// OrderStatus mapping
			int statusIndex = (int)order.Status;
			var newOrderStatus = new OrderStatusViewModel();

			switch (statusIndex)
			{
				case 0: newOrderStatus = OrderStatusViewModel.Created; break;
				case 1: newOrderStatus = OrderStatusViewModel.Processed; break;
				case 2: newOrderStatus = OrderStatusViewModel.Delivering; break;
				case 3: newOrderStatus = OrderStatusViewModel.Delivered; break;
				case 4: newOrderStatus = OrderStatusViewModel.Received; break;
				case 5: newOrderStatus = OrderStatusViewModel.Canceled; break;
			}

			var orderViewModel = new OrderViewModel
			{
				Id = order.Id,
				UserOrderInfo = new UserOrderInfoViewModel
				{
					Name = order.UserOrderInfo.Name,
					Surname = order.UserOrderInfo.Surname,
					Email = order.UserOrderInfo.Email,
					Phone = order.UserOrderInfo.Phone,
					City = order.UserOrderInfo.City,
					Street = order.UserOrderInfo.Street
				},
				Items = itemsViewModel,
				Status = newOrderStatus,
				CreationTime = order.CreationTime,
				Price = order.Price
			};

			return View(orderViewModel);
		}

		[HttpPost]
		public ActionResult UpdateStatus(Guid id, OrderStatusViewModel newStatus)
		{
			int statusIndex = (int)newStatus;
			var newOrderStatus = new OrderStatus();

			switch (statusIndex)
			{
				case 0: newOrderStatus = OrderStatus.Created; break;
				case 1: newOrderStatus = OrderStatus.Processed; break;
				case 2: newOrderStatus = OrderStatus.Delivering; break;
				case 3: newOrderStatus = OrderStatus.Delivered; break;
				case 4: newOrderStatus = OrderStatus.Received; break;
				case 5: newOrderStatus = OrderStatus.Canceled; break;
			}

			ordersStorage.UpdateStatus(id, newOrderStatus);
			return RedirectToAction("Index");

		}

	}
}
