using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.Repository;
using ShopDAW.Domain.Models;
using ShopDAW.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopDAW.Services.Implementation
{

	public class ProductService : BaseServices, IProductService
	{
		public IProductRepository ProductRepository { get; }

		

		public ProductService(ShopDBContext context, IProductRepository productRepository) : base(context)
		{
			ProductRepository = productRepository;
		}
	}
}
