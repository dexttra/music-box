using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartsStorage.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = ProductsStorage.TryGetById(productId);
            CartsStorage.Add(product, Constants.UserId);
            return RedirectToAction("Index");          
        }
    }
}
