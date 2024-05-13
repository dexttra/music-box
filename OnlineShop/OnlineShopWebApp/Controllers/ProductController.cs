using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db.Repositories;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
	{
		private readonly IProductsRepository productsStorage;

		public ProductController(IProductsRepository productsStorage)
		{
			this.productsStorage = productsStorage;
		}

		public IActionResult Index(Guid id)
		{
			var product = productsStorage.TryGetById(id);

			var productViewModel = new ProductViewModel
			{
				Id = product.Id,
				Name = product.Name,
				Description = product.Description,
				Price = product.Price,
				ImagePath = product.ImagePath
			};
			return View(productViewModel);
		}
	}
}

