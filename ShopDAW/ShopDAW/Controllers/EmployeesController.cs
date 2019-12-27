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
    [Route("api/employee")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
		private readonly IEmployeeService _employeeServices;

		public EmployeesController(IEmployeeService employeeServices)
		{
			_employeeServices = employeeServices;
		}

		[HttpGet("GetAllEmployees")]
		public async Task<ObjectResult> GetAllEmployeesAsync()
		{
			List<Employee> result = await _employeeServices.EmployeeRepository.GetAllAsync();

			return Ok(result);
		}

		
		[HttpGet("GetEmployee/{id}")]
		public async Task<ObjectResult> GetEmployeeAsync([FromRoute] int id)
		{
			Employee result = await _employeeServices.EmployeeRepository.GetByIdAsync(id);

			return Ok(result);
		}


		[HttpPost("CreateEmployee")]
		public async Task<ObjectResult> CreateEmployeeAsync([FromBody] GeneralEmployeeRequest request)
		{
			Employee result = await _employeeServices.EmployeeRepository.CreateAsync(request.ToDTOEmployee());
			await _employeeServices.CommitChanges();

			return Ok(result);
		}

		[HttpPut("UpdateEmployee/{id}")]
		public async Task<ObjectResult> UpdateEmployeeAsync([FromBody] GeneralEmployeeRequest request, [FromRoute] int id)
		{
			Employee result = _employeeServices.EmployeeRepository.Update(request.ToDTOEmployee(id));
			await _employeeServices.CommitChanges();

			return Ok(result);
		}

		[HttpDelete("DeleteEmployee/{id}")]
		public async Task<ObjectResult> DeleteEmployeeAsync([FromRoute] int id)
		{
			Employee employee = await _employeeServices.EmployeeRepository.GetByIdAsync(id);
			_employeeServices.EmployeeRepository.Delete(employee);
			await _employeeServices.CommitChanges();

			return Ok(employee);
		}
		
	}
}
