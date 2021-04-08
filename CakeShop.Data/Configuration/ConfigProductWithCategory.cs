using CakeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CakeShop.Data.Configuration
{
    public class ConfigProductWithCategory : IEntityTypeConfiguration<ProductWithCategory>
    {
        public void Configure(EntityTypeBuilder<ProductWithCategory> builder)
        {
            builder.ToTable("ProductCategorys");
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.HasOne(x => x.Product).WithMany(x => x.ProductWithCategories).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Category).WithMany(x => x.ProductWithCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
