using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
	public enum OrderStatus
	{
		[Display(Name = "Создан")]
		Created,

		[Display(Name = "Обработан")]
		Processed,

		[Display(Name = "Доставляется")]
		Delivering,

		[Display(Name = "Ожидает выдачи")]
		Delivered,

		[Display(Name = "Получен")]
		Received,

		[Display(Name = "Отменен")]
		Canceled
	}
}