using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Registration
    {
        [EmailAddress]
        [Required(ErrorMessage = "Укажите email")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Длина email'а должна быть от 3 до 30 символов")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите пароль")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Длина пароля должна быть от 8 до 50 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
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