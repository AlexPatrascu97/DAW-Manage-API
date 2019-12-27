using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.IRepository;
using ShopDAW.Domain.EntityFramework.Repository;
using ShopDAW.Services.Implementation;
using ShopDAW.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDAW.WebAPI
{
	public static class ServiceExtensionMethods
	{

		public static void ConfigureSqlDbContext(this IServiceCollection serv, IConfiguration config)
		{

			string conncetionString = config["DatabaseConnections:sqlConnectionString"];
			serv.AddDbContext<ShopDBContext>(server => server.UseSqlServer(conncetionString,b =>b.MigrationsAssembly("ShopDAW.WebAPI")));

		}
		public static void InjectRepositories(this IServiceCollection services)
		{
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IEmployeeRepository, EmployeeRepository>();
			services.AddScoped<IOrderRepository, OrderRepository>();
			services.AddScoped<IProviderRepository, ProviderRepository>();
		}

		public static void InjectServices(this IServiceCollection services)
		{
			services.AddScoped<IProductService, ProductService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IEmployeeService, EmployeeService>();
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped< IProviderService, ProviderService>();
		}
	}
}
