using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class ProductViewModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "Укажите название")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Укажите стоимость")]
		public decimal Price { get; set; }
		[Required(ErrorMessage = "Укажите описание")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Укажите ссылку на изображение")]
		public string ImagePath { get; set; }
	}
}
