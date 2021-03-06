﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.Request
{
	public class GeneralProviderRequest
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public int Payment { get; set; }
		public DateTime PayDay { get; set; }
		public bool Payed { get; set; }
	}
}
