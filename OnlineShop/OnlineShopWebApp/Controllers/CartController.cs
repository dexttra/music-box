using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartsStorage.TryGetByUserId(1);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = ProductsStorage.TryGetById(productId);
            CartsStorage.Add(product, 1);
            return RedirectToAction("Index");          
        }
    }
}
