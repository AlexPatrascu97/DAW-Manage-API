using ShopDAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.Models
{
	public class Provider: BaseEntity
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public int Payment { get; set; }
		public DateTime PayDay { get; set; }
		public bool Payed { get; set; }
	}
}
