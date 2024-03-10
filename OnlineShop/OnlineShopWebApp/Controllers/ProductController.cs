using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            var product = ProductsStorage.TryGetById(id);
            if (product != null) return product.ToString();
            return "Товар не найден.";
        }
    }
}
