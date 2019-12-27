using ShopDAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.Models
{
	public class Order : BaseEntity
	{
		public int Quantity { get; set; }

		

		public int UserId { get; set; }
		public User User { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }

	}
}
