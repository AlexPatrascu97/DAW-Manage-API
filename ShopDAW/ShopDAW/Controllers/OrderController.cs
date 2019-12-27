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
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
		private readonly IOrderService _orderServices;

		public OrderController(IOrderService orderServices)
		{
			_orderServices = orderServices;
		}

		[HttpGet("GetAllOrders")]
		public async Task<ObjectResult> GetAllOrdersAsync()
		{
			List<Order> result = await _orderServices.OrderRepository.GetAllAsync();

			return Ok(result);
		}

		
		[HttpGet("GetOrder/{id}")]
		public async Task<ObjectResult> GetOrderAsync([FromRoute] int id)
		{
			Order result = await _orderServices.OrderRepository.GetByIdAsync(id);

			return Ok(result);
		}


		[HttpPost("CreateOrder")]
		public async Task<ObjectResult> CreateOrderAsync([FromBody] GeneralOrderRequest request)
		{
			Order result = await _orderServices.OrderRepository.CreateAsync(request.ToDTOOrder());
			await _orderServices.CommitChanges();

			return Ok(result);
		}
		
		[HttpPut("UpdateOrder/{id}")]
		public async Task<ObjectResult> UpdateOrderAsync([FromBody] GeneralOrderRequest request, [FromRoute] int id)
		{
			Order result = _orderServices.OrderRepository.Update(request.ToDTOOrder(id));
			await _orderServices.CommitChanges();

			return Ok(result);
		}

		[HttpDelete("DeleteOrder/{id}")]
		public async Task<ObjectResult> DeleteOrderAsync([FromRoute] int id)
		{
			Order order = await _orderServices.OrderRepository.GetByIdAsync(id);
			_orderServices.OrderRepository.Delete(order);
			await _orderServices.CommitChanges();

			return Ok(order);
		}
		
	}
}