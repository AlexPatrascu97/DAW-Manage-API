using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.EntityFramework.ModelConfiguration
{
	public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.HasKey(c => c.Id);
			builder.HasIndex(c => c.Id);
		}
	}
}
