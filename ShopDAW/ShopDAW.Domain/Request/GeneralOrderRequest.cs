using ShopDAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.Request
{
	public class GeneralOrderRequest
	{
		public int Id { get; set; }
		public int Quantity { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
