using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public class ChangeUserPassword
	{
		public string UserName { get; set; }

		[Required(ErrorMessage = "Укажите пароль")]
		[StringLength(50, MinimumLength = 8, ErrorMessage = "Длина пароля должна быть от 8 до 50 символов")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Подтвердите пароль")]
		[Compare("Password", ErrorMessage = "Пароли не совпадают")]
		public string ConfirmPassword { get; set; }


		public ChangeUserPassword()
		{

		}
	}
}
