using ShopDAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.Models
{
	public class User : BaseEntity
	{
		
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Role { get; set; }

		public virtual ICollection<Order> Orders { get; set; }

	}
}
