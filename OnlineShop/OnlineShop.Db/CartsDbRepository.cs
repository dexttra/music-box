using Microsoft.EntityFrameworkCore;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using System.Reflection.Metadata.Ecma335;

namespace OnlineShopWebApp.Models
{
	public class CartsDbRepository : ICartsRepository
	{
		private readonly DatabaseContext databaseContext;

		public CartsDbRepository(DatabaseContext databaseContext)
		{
			this.databaseContext = databaseContext;
		}

		public DbSet<Cart> Carts { get; set; }

		public List<Cart> GetAll(Guid userId) 
		{
			return Carts.ToList();
		}

		public Cart TryGetByUserId(Guid userId)
		{
			return databaseContext.Carts.SingleOrDefault(cart => cart.UserId == userId);
		}

		public void Add(Guid userId, Product product)
		{
			var existingCart = TryGetByUserId(userId);
			if (existingCart is null)
			{
				var newCart = new Cart(userId);
				newCart.Items = new List<CartItem>
				{
					new CartItem(product, 1)
				};
				Cart.Add(newCart);
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
					existingCart.Items.Add(new CartItem(product, 1));
				}
			}
		}

		public void RemoveItem(Guid userId, Guid productId)
		{
			var cart = TryGetByUserId(userId);
			var cartItem = cart.Items.SingleOrDefault(item => item.Product.Id == productId);

			if (cartItem.Amount == 1) cart.Items.Remove(cartItem);
			else cartItem.Amount -= 1;
		}

		public void ClearAll(Guid userId)
		{
            var cart = TryGetByUserId(userId);
            cart.Items.Clear();
		}
	}
}
