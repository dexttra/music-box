using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
		
	}
}
