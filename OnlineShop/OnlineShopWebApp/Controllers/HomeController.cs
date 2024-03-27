using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using OnlineShopWebApp.Models;


namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsStorage productsStorage;
        private readonly ICartsStorage cartsStorage;

        public HomeController(IProductsStorage productsStorage, ICartsStorage cartsStorage)
        {
            this.productsStorage = productsStorage;
            this.cartsStorage = cartsStorage;
        }

        public IActionResult Index()
        {
            var cart = cartsStorage.TryGetByUserId(Constants.UserId);
            ViewBag.ProductCount = cart?.Amount;
            var products = productsStorage.GetAll();
            return View(products);
        }
    }
}
