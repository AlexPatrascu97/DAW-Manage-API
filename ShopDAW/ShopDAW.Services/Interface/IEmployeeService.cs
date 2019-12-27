using ShopDAW.Domain.EntityFramework.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Interface
{
	public interface IEmployeeService : IBaseService
	{
		IEmployeeRepository EmployeeRepository { get; }
	}
}
