namespace OnlineShopWebApp.Models
{
	public class Registration
	{
		

		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }

		public Registration(string email, string password, string confirmPassword)
		{
			Email = email;
			Password = password;
			ConfirmPassword = confirmPassword;
		}

		public Registration() 
		{
		}


	}
}
