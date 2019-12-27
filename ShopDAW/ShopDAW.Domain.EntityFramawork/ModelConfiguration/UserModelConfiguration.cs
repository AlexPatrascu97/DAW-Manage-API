using Microsoft.EntityFrameworkCore;
using ShopDAW.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ShopDAW.Domain.EntityFramework.ModelConfiguration
{
	public class UserEntityConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(c => c.Id);
			builder.HasIndex(c => c.Id);
		}
	}
}
