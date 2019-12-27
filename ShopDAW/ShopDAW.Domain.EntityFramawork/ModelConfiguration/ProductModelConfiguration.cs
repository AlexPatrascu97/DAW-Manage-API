
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopDAW.Domain.Models;

namespace DAW.Domain.EF.ModelConfigurations
{
	public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(c => c.Id);
			builder.HasIndex(c => c.Id);
		}
	}
}