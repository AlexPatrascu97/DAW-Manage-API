using ShopDAW.Domain.EntityFramework.Repository;
using ShopDAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Interface
{
	public interface IProductService: IBaseService
	{
		IProductRepository ProductRepository { get; }
	}
}
