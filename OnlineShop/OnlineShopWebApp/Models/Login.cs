using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Login
    {
        [EmailAddress]
        [Required(ErrorMessage = "Укажите email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите пароль")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public Login(string email, string password, bool rememberMe)
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