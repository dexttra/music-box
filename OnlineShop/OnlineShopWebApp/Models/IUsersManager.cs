
namespace OnlineShopWebApp.Models
{
	public interface IUsersManager
	{
		void Add(User user);
		void ChangePassword(string userName, string newPassword);
		void Delete(string name);
		List<User> GetAll();
		User TryGetByName(string name);
	}
}