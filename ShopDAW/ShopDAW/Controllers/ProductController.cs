using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDAW.Domain.ExtensionMethods;
using ShopDAW.Domain.Models;
using ShopDAW.Domain.Request;
using ShopDAW.Services.Interface;

namespace ShopDAW.WebAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
		private readonly IProductService _productServices;

		public ProductController(IProductService productServices)
		{
			_productServices = productServices;
		}

		[HttpGet("GetAllProducts")]
		public async Task<ObjectResult> GetAllCustomersAsync()
		{
			List<Product> result = await _productServices.ProductRepository.GetAllAsync();

			return Ok(result);
		}


		[HttpGet("GetProduct/{id}")]
		public async Task<ObjectResult> GetProductAsync([FromRoute] int id)
		{
			Product result = await _productServices.ProductRepository.GetByIdAsync(id);

			return Ok(result);
		}


		[HttpPost("CreateProduct")]
		public async Task<ObjectResult> CreateCustomerAsync([FromBody] GeneralProductRequest request)
		{
			Product result = await _productServices.ProductRepository.CreateAsync(request.ToDTO());
			await _productServices.CommitChanges();

			return Ok(result);
		}

		[HttpPut("UpdateProduct/{id}")]
		public async Task<ObjectResult> UpdateCustomerAsync([FromBody] GeneralProductRequest request, [FromRoute] int id)
		{
			Product result = _productServices.ProductRepository.Update(request.ToDTO(id));
			await _productServices.CommitChanges();

			return Ok(result);
		}

		[HttpDelete("DeleteProduct/{id}")]
		public async Task<ObjectResult> DeleteCustomerAsync([FromRoute] int id)
		{
			Product product = await _productServices.ProductRepository.GetByIdAsync(id);
			_productServices.ProductRepository.Delete(product);
			await _productServices.CommitChanges();

			return Ok(product);
		}


	}
}