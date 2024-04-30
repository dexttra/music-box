using System.Xml;

namespace OnlineShopWebApp.Models
{
	public class User
	{

		private static int uniqId;
		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }

		public User(string name, string password)
		{
			Id = uniqId++;
			Name = name;
			Password = password;
		}

		public User()
		{
		}

	}
}
