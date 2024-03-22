using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

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
    }
}
