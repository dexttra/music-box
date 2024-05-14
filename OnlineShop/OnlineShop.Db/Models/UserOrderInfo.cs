using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace OnlineShopWebApp.Models
{
	public class UserOrderInfo
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
		public string Street { get; set; }

	}
}
