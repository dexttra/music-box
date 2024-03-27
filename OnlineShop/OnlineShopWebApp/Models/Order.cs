namespace OnlineShopWebApp.Models
{
	public class Order
	{
		public int Id { get; }
		private static int uniqId = 0;
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string City { get; set; }
		public string Street { get; set; } 
		public string StreetNumber { get; set; }
		public Cart Cart { get; set; }

		public Order(string name, string surname, string email, string city, string street, string streetNumber, Cart cart)
		{
			Id = uniqId++;
			Name = name;
			Surname = surname;
			Email = email;
			City = city;
			Street = street;
			StreetNumber = streetNumber;
			Cart = cart;
		}

		public Order()
		{
		}
	}
}
