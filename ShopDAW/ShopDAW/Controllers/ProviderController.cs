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
	[Route("api/provider")]
	[ApiController]
	public class ProviderController : ControllerBase
	{
		private readonly IProviderService _providerServices;

		public ProviderController(IProviderService providerServices)
		{
			_providerServices = providerServices;
		}

		[HttpGet("GetAllProviders")]
		public async Task<ObjectResult> GetAllProvidersAsync()
		{
			List<Provider> result = await _providerServices.ProviderRepository.GetAllAsync();

			return Ok(result);
		}


		[HttpGet("GetProvider/{id}")]
		public async Task<ObjectResult> GetProviderAsync([FromRoute] int id)
		{
			Provider result = await _providerServices.ProviderRepository.GetByIdAsync(id);

			return Ok(result);
		}


		[HttpPost("CreateProvider")]
		public async Task<ObjectResult> CreateProviderAsync([FromBody] GeneralProviderRequest request)
		{
			Provider result = await _providerServices.ProviderRepository.CreateAsync(request.ToDTOProvider());
			await _providerServices.CommitChanges();

			return Ok(result);
		}

		[HttpPut("UpdateProvider/{id}")]
		public async Task<ObjectResult> UpdateProviderAsync([FromBody] GeneralProviderRequest request, [FromRoute] int id)
		{
			Provider result = _providerServices.ProviderRepository.Update(request.ToDTOProvider(id));
			await _providerServices.CommitChanges();

			return Ok(result);
		}

		[HttpDelete("DeleteProvider/{id}")]
		public async Task<ObjectResult> DeleteProviderAsync([FromRoute] int id)
		{
			Provider provider = await _providerServices.ProviderRepository.GetByIdAsync(id);
			_providerServices.ProviderRepository.Delete(provider);
			await _providerServices.CommitChanges();

			return Ok(provider);
		}
	}
}