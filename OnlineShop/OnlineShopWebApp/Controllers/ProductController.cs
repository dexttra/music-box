﻿using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsStorage productsStorage;
        
        public ProductController(ProductsStorage productsStorage)
        {
            this.productsStorage = productsStorage;
        }

        public IActionResult Index(int id)
        {
            var product = productsStorage.TryGetById(id);
            return View(product);
        }
    }
}
