
namespace OnlineShopWebApp.Models
{
	public interface IUsersManager
	{
		void Add(User user);
		void ChangePassword(string userName, string newPassword);
		List<User> GetAll();
		User TryGetByName(string name);
	}
}