using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using OnlineShop.Db;
using OnlineShopWebApp.Models;


namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productsStorage;
        private readonly ICartsStorage cartsStorage;

        public HomeController(IProductsRepository productsStorage, ICartsStorage cartsStorage)
        {
            this.productsStorage = productsStorage;
            this.cartsStorage = cartsStorage;
        }

        public IActionResult Index()
        {
            var products = productsStorage.GetAll();
            var productsViewModel = new List<ProductViewModel>();
            foreach (var product in products) 
            {
                var productViewModel = new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    ImagePath = product.ImagePath
                };
                productsViewModel.Add(productViewModel);
            }
            return View(productsViewModel);
        }
    }
}
