using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Views.Shared.ViewComponents.CartViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartsStorage cartsStorage;

        public CartViewComponent(ICartsStorage cartsStorage)
        {
            this.cartsStorage = cartsStorage;
        }

        public IViewComponentResult Invoke()
        {
            var cart = cartsStorage.TryGetByUserId(Constants.UserId);
            var productCount = cart?.Amount ?? 0;

            return View("Cart", productCount);
        }
    }
}
