using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class Product
	{
		private static int uniqId = 1;
		public int Id { get; set; }

		[Required(ErrorMessage = "Укажите название")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Укажите стоимость")]
		public decimal Price { get; set; }
		[Required(ErrorMessage = "Укажите описание")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Укажите ссылку на изображение")]
		public string ImagePath { get; set; }


		public Product()
		{
			Id = uniqId++;
		}

		public Product(string name, decimal price, string description, string imagePath) : this()
		{
			Name = name;
			Price = price;
			Description = description;
			ImagePath = imagePath;
		}



	}
}
