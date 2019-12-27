using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.EntityFramework.Repository
{
	public class ProductRepository : RepositoryBase<Product>, IProductRepository
	{
		public ProductRepository(ShopDBContext context) : base(context) 
		{
		}
	}
}
