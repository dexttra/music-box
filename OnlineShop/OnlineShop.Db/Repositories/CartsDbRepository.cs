using Microsoft.EntityFrameworkCore;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;

namespace OnlineShop.Db.Repositories
{
    public class CartsDbRepository : ICartsRepository
    {
        private readonly DatabaseContext databaseContext;

        public CartsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Cart> GetAll(Guid userId)
        {
            return databaseContext.Carts.ToList();
        }

        public Cart? TryGetByUserId(Guid userId)
        {
            return databaseContext.Carts.Include(c => c.Items).ThenInclude(ci => ci.Product).SingleOrDefault(c => c.Id == userId);
        }

        public void Add(Guid userId, Product product)
        {
            var existingCart = TryGetByUserId(userId);
            if (existingCart is null)
            {
                var newCart = new Cart
                {
                    Id = userId
                };
                var newItem = new CartItem
                {
                    Product = product,
                    Amount = 1
                };
                newCart.Items.Add(newItem);
                databaseContext.Carts.Add(newCart);
                databaseContext.SaveChanges();
            }
            else
            {
                var existingCartItem = existingCart.Items.SingleOrDefault(item => item.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount += 1;
                }
                else
                {
                    existingCart.Items.Add(
                        new CartItem
                        {                           
                            Product = product,
                            Amount = 1
                        });
                }
                databaseContext.SaveChanges();
            }
        }

        public void RemoveItem(Guid userId, Guid productId)
        {
            var cart = TryGetByUserId(userId);
            var cartItem = cart.Items.SingleOrDefault(item => item.Product.Id == productId);

            if (cartItem.Amount == 1) cart.Items.Remove(cartItem);
            else cartItem.Amount -= 1;
            databaseContext.SaveChanges();
        }

        public void ClearAll(Guid userId)
        {
            var cart = TryGetByUserId(userId);
            cart.Items.Clear();
            databaseContext.SaveChanges();
        }
    }
}
