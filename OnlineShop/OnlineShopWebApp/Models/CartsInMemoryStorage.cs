using Microsoft.AspNetCore.Http.Features;
using System.Reflection.Metadata.Ecma335;

namespace OnlineShopWebApp.Models
{
	public class CartsInMemoryStorage : ICartsStorage
	{
		private readonly List<Cart> carts = new List<Cart>();


		public List<Cart> GetAll(int userId) 
		{
			return carts;
		}

		public Cart TryGetByUserId(int userId)
		{
			return carts.SingleOrDefault(cart => cart.UserId == userId);
		}

		public void Add(Product product, int userId)
		{
			var existingCart = TryGetByUserId(userId);
			if (existingCart is null)
			{
				var newCart = new Cart(userId);
				newCart.Items = new List<CartItem>
				{
					new CartItem(product, 1)
				};
				carts.Add(newCart);
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

		public void Remove(Product product, int userId)
		{
			var cart = TryGetByUserId(userId);
			var cartItem = cart.Items.SingleOrDefault(item => item.Product.Id == product.Id);

			if (cartItem.Amount == 1) cart.Items.Remove(cartItem);
			else cartItem.Amount -= 1;
		}

		public void ClearAll(Cart cart)
		{
			cart.Items.Clear();
		}
	}
}
