using ShopDAW.Domain.EntityFramework.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Interface
{
	public interface IOrderService : IBaseService
	{
		IOrderRepository OrderRepository { get; }
	}
}
