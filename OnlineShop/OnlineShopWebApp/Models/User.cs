using System.Xml;

namespace OnlineShopWebApp.Models
{
	public class User
	{

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }

		public User(string name, string password)
		{
			Id = new Guid();
			Name = name;
			Password = password;
		}

		public User()
		{
		}

	}
}
