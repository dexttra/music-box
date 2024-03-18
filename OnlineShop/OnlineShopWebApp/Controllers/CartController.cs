using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly CartsStorage cartsStorage;
		private readonly ProductsStorage productsStorage;

		public CartController(CartsStorage cartsStorage, ProductsStorage productsStorage)
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
    }
}
