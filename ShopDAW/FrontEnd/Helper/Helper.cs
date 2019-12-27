using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Helper
{
	public class ProductAPI
	{
		public HttpClient Initial()
		{
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:44360/");
			return client;
		}
	}
}
