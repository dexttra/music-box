using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class Order
	{
		public int Id { get; }
		private static int uniqId = 0;
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
		public Cart Cart { get; set; }

		public Order(string name, string surname, string email, string phone, string city, string street, Cart cart)
		{
			Id = uniqId++;
			Name = name;
			Surname = surname;
			Email = email;
			Phone = phone;
			City = city;
			Street = street;
			Cart = cart;
		}

		public Order()
		{
		}
	}
}
