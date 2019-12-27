using ShopDAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.Models
{
	public class Employee : BaseEntity
	{
		public string  FirstName { get; set; }
		public string  LastName { get; set; }
		public DateTime StartingDay { get; set; }
		public DateTime? LastDay { get; set; }
		public string Post { get; set; }
		public int Salary { get; set; }


	}
}
