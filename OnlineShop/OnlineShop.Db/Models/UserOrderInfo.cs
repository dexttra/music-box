using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace OnlineShopWebApp.Models
{
	public class UserOrderInfo
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
		public string Street { get; set; }

		public UserOrderInfo(string name, string surname, string email, string phone, string city, string street)
		{
			Name = name;
			Surname = surname;
			Email = email;
			Phone = phone;
			City = city;
			Street = street;
		}

		public UserOrderInfo()
		{
		}
	}
}
