using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace OnlineShopWebApp.Models
{
	public class UserOrderInfoViewModel
	{
		[Required(ErrorMessage = "Заполните поле")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Заполните поле")]
		public string Surname { get; set; }

		[EmailAddress]
		[Required(ErrorMessage = "Заполните поле")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Заполните поле")]
		public string Phone { get; set; }
		[Required(ErrorMessage = "Заполните поле")]
		public string City { get; set; }
		[Required(ErrorMessage = "Заполните поле")]
		public string Street { get; set; }

		public UserOrderInfoViewModel(string name, string surname, string email, string phone, string city, string street)
		{
			Name = name;
			Surname = surname;
			Email = email;
			Phone = phone;
			City = city;
			Street = street;
		}

		public UserOrderInfoViewModel()
		{
		}
	}
}
