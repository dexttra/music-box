using Microsoft.AspNetCore.Identity;

namespace OnlineShopWebApp.Models
{
	public class UsersManager : IUsersManager
	{
		private readonly List<User> users = new List<User>();

		public List<User> GetAll()
		{
			return users;
		}

		public void Add(User user)
		{
			users.Add(user);
		}

		public User TryGetByName(string name)
		{
			return users.FirstOrDefault(user => user.Name == name);
		}

		public void ChangePassword(string userName, string newPassword)
		{
			var user = TryGetByName(userName);
			user.Password = newPassword;
		}

		public void Delete(string name)
		{
			var user = TryGetByName(name);
			users.Remove(user);
		}
	}
}
