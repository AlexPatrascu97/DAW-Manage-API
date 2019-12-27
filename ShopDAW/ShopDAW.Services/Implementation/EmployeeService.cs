using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.IRepository;
using ShopDAW.Domain.EntityFramework.Repository;
using ShopDAW.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Implementation
{
	public class EmployeeService : BaseServices, IEmployeeService
	{
		public IEmployeeRepository EmployeeRepository { get; }



		public EmployeeService(ShopDBContext context, IEmployeeRepository employeeRepository) : base(context)
		{
			EmployeeRepository = employeeRepository;
		}
	}
}
