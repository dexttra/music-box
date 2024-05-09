using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
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
            return View(product);
        }
    }
}
