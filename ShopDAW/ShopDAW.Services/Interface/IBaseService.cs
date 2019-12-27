using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAW.Services.Interface
{
	public interface IBaseService
	{
		Task CommitChanges();
	}
}
