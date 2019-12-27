using ShopDAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.Models
{
	public class Product : BaseEntity
	{
		
		public string Name { get; set; }
		public int Price { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public int Quantity { get; set; }

		public virtual ICollection<Order> Orders { get; set; }

	}
}
