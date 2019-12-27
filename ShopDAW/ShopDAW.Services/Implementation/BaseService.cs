using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAW.Services.Implementation
{
	public class BaseServices : IBaseService
	{
		private readonly ShopDBContext _context;

		public BaseServices(ShopDBContext context)
		{
			_context = context;
		}

		public async Task CommitChanges()
		{
			await _context.SaveChangesAsync(true);
		}
	}
}
