using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Db.Models
{
    public class Product
    {
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImagePath { get; set; }

		public Product(Guid id, string name, decimal price, string description, string imagePath)
		{
			Id = id;
			Name = name;
			Price = price;
			Description = description;
			ImagePath = imagePath;
		}
		public Product()
		{
		}
	}
}
