using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.IRepository;
using ShopDAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.EntityFramework.Repository
{
	public class OrderRepository : RepositoryBase<Order>, IOrderRepository
	{
		public OrderRepository(ShopDBContext context) : base(context)
		{
		}
	}
}
