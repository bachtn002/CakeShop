using CakeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CakeShop.Data.Configuration
{
    public class ConfigProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.IdProduct);
            builder.Property(x => x.IdProduct).UseIdentityColumn();
            builder.Property(x => x.ProductPrice).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.OriginalPrice).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.StockProduct).IsRequired();
            builder.Property(x => x.BrandProduct).IsRequired().HasMaxLength(200);
            builder.Property(x => x.WeightProduct).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.CodeProduct).IsRequired().HasMaxLength(200);
            builder.Property(x => x.DateCreate).IsRequired();
            builder.Property(x => x.ImageProduct).IsRequired().HasMaxLength(500);

        }
    }
}
