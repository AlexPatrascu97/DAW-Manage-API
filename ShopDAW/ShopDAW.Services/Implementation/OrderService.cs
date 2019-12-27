using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.IRepository;
using ShopDAW.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Implementation
{
	public class OrderService : BaseServices, IOrderService
	{
		public IOrderRepository OrderRepository { get; }



		public OrderService(ShopDBContext context, IOrderRepository orderRepository) : base(context)
		{
			OrderRepository = orderRepository;
		}
	}
}
