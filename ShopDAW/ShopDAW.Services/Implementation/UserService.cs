using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.IRepository;
using ShopDAW.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Services.Implementation
{
	public class UserService : BaseServices, IUserService
	{
		public IUserRepository UserRepository { get; }



		public UserService(ShopDBContext context, IUserRepository userRepository) : base(context)
		{
			UserRepository = userRepository;
		}
	}
}
