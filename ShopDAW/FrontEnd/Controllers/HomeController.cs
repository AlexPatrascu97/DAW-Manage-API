using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontEnd.Models;
using FrontEnd.Helper;
using System.Net.Http;
using Newtonsoft.Json;

namespace FrontEnd.Controllers
{
	public class HomeController : Controller
	{
		ProductAPI _api = new ProductAPI();

		public async Task<IActionResult> Index()
		{
			List<ProductData> products = new List<ProductData>();
			HttpClient client = _api.Initial();
			HttpResponseMessage res = await client.GetAsync("api/product/GetAllProducts");

			if (res.IsSuccessStatusCode) {
				var result = res.Content.ReadAsStringAsync().Result;
				products = JsonConvert.DeserializeObject<List<ProductData>>(result);
			}


			return View(products);

		}



		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
