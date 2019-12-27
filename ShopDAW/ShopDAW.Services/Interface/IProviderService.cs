using ShopDAW.Domain.EntityFramework.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Interface
{
	public interface IProviderService: IBaseService
	{
		IProviderRepository ProviderRepository { get; }
	}
}
