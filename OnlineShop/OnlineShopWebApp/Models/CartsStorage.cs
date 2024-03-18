﻿using Microsoft.AspNetCore.Http.Features;

namespace OnlineShopWebApp.Models
{
	public class CartsStorage
	{
		public readonly List<Cart> Carts = new List<Cart>();

		public Cart TryGetByUserId(int userId)
		{
			return Carts.SingleOrDefault(cart => cart.UserId == userId);
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
				Carts.Add(newCart);
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
	}
}
