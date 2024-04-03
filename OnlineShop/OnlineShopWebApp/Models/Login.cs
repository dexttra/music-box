namespace OnlineShopWebApp.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public Login(string email, string password, string passwordConfirm, bool rememberMe)
        {
            Email = email;
            Password = password;      
            RememberMe = rememberMe;
        }

		public Login()
		{
		
		}
	}
}
