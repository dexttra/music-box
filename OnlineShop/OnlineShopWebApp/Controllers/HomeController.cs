using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;


namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsStorage productsStorage;

        public HomeController(ProductsStorage productsStorage)
        {
            this.productsStorage = productsStorage;
        }

        public IActionResult Index()
        {       
            var products = productsStorage.Products;
            return View(products);
        }
    }
}
