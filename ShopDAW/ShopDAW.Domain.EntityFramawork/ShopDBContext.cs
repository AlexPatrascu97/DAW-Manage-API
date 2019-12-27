using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ShopDAW.Domain.Models;
using DAW.Domain.EF.ModelConfigurations;
using ShopDAW.Domain.EntityFramework.ModelConfiguration;

namespace ShopDAW.Domain.EntityFramawork

{
	public class ShopDBContext : DbContext
	{
		public ShopDBContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<Provider> Providers { get; set; }
		


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
			modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
			modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
			modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
			modelBuilder.ApplyConfiguration(new ProviderEntityConfiguration());
			


		}

	}
}
