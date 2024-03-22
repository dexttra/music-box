using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;


namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsStorage productsStorage;

        public HomeController(IProductsStorage productsStorage)
        {
            this.productsStorage = productsStorage;
        }

        public IActionResult Index()
        {
            var products = productsStorage.GetAll();
            return View(products);
        }
    }
}
