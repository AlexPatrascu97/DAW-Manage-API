using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.ExtensionMethods;
using ShopDAW.Domain.Models;
using ShopDAW.Domain.Request;
using ShopDAW.Services.Interface;

namespace ShopDAW.WebAPI.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUserService _userServices;

		public UsersController(IUserService userServices)
		{
			_userServices = userServices;
		}

		[HttpGet("GetAllUsers")]
		public async Task<ObjectResult> GetAllUsersAsync()
		{
			List<User> result = await _userServices.UserRepository.GetAllAsync();

			return Ok(result);
		}


		[HttpGet("GetUser/{id}")]
		public async Task<ObjectResult> GetUserAsync([FromRoute] int id)
		{
			User result = await _userServices.UserRepository.GetByIdAsync(id);

			return Ok(result);
		}


		[HttpPost("CreateUser")]
		public async Task<ObjectResult> CreateUserAsync([FromBody] GeneralUserRequest request)
		{
			User result = await _userServices.UserRepository.CreateAsync(request.ToDTOUser());
			await _userServices.CommitChanges();

			return Ok(result);
		}

		[HttpPut("UpdateUser/{id}")]
		public async Task<ObjectResult> UpdateUserAsync([FromBody] GeneralUserRequest request, [FromRoute] int id)
		{
			User result = _userServices.UserRepository.Update(request.ToDTOUser(id));
			await _userServices.CommitChanges();

			return Ok(result);
		}

		[HttpDelete("DeleteUser/{id}")]
		public async Task<ObjectResult> DeleteUserAsync([FromRoute] int id)
		{
			User user = await _userServices.UserRepository.GetByIdAsync(id);
			_userServices.UserRepository.Delete(user);
			await _userServices.CommitChanges();

			return Ok(user);
		}

	}
}
