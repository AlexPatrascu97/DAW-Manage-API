using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.IRepository;
using ShopDAW.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Implementation
{
	public class ProviderService : BaseServices, IProviderService
	{
		public IProviderRepository ProviderRepository { get; }



		public ProviderService(ShopDBContext context, IProviderRepository providerRepository) : base(context)
		{
			ProviderRepository = providerRepository;
		}
	}
}
