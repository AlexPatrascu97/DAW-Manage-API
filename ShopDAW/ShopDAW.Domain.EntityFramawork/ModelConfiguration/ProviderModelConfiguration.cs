using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDAW.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopDAW.Domain.EntityFramework.ModelConfiguration
{
	public class ProviderEntityConfiguration : IEntityTypeConfiguration<Provider>
	{
		public void Configure(EntityTypeBuilder<Provider> builder)
		{
			builder.HasKey(c => c.Id);
			builder.HasIndex(c => c.Id);
		}
	}
}
